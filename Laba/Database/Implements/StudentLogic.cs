using Database.Models;
using Library.BindingModels;
using Library.Interfaces;
using Library.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Implements
{
    public class StudentLogic: IStudentLogic
    {
        public void CreateOrUpdate(StudentBindingModel model)
        {
            using (var context = new StudentDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        Student element = context.Students.FirstOrDefault(rec => rec.FIO == model.FIO && rec.Id != model.Id);
                        if (element != null)
                        {
                            throw new Exception("Уже есть такой студент");
                        }
                        if (model.Id.HasValue)
                        {
                            element = context.Students.FirstOrDefault(rec => rec.Id == model.Id);

                            if (element == null)
                            {
                                throw new Exception("Элемент не найден");
                            }
                        }
                        else
                        {
                            element = new Student();
                            context.Students.Add(element);
                        }

                        element.FIO = model.FIO;
                        element.DatePostuplenie = model.DatePostuplen;
                        context.SaveChanges();
                        if (model.Id.HasValue)
                        {
                            Console.WriteLine("if");
                            var shipComponents = context.NapravlenieStudents
                                .Include(rec => rec.Napravlenie)
                                .Where(rec => rec.StudentId == model.Id.Value).ToList();
                            foreach (var sh in shipComponents)
                            {
                                Console.WriteLine("@ StudentId=" + sh.StudentId + ", " + sh.NapravlenieId);
                            }
                            context.NapravlenieStudents.RemoveRange(shipComponents.Where(rec => !model.Napravlenies.ContainsKey(rec.StudentId.ToString())).ToList());
                            Console.WriteLine("RemoveRange");
                            context.SaveChanges();
                            foreach (var updateComponent in shipComponents)
                            {
                                Console.WriteLine("# "+ updateComponent.NapravlenieId);
                                updateComponent.Napravlenie.Name=
                                    model.Napravlenies[updateComponent.NapravlenieId.ToString()];
                                //model.Napravlenies[updateComponent.NapravlenieId.ToString()];
                            }
                            context.SaveChanges();
                        }
                        foreach (var pc in model.Napravlenies)
                        {
                            Console.WriteLine("CorU NapravlenieId=" + Convert.ToInt32(pc.Key));
                            Console.WriteLine("CorU StudentId=" + element.Id);
                            context.NapravlenieStudents.Add(new NapravlenieStudent
                            {
                                NapravlenieId = Convert.ToInt32(pc.Key),
                                StudentId = element.Id,
                                //FIO = pc.Value.Item1,
                                //DatePostuplenie= pc.Value.Item2
                            });
                            context.SaveChanges();
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public void Delete(StudentBindingModel model)
        {
            using (var context = new StudentDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.NapravlenieStudents.RemoveRange(context.NapravlenieStudents.Where(rec => rec.StudentId == model.Id));
                        Student element = context.Students.FirstOrDefault(rec => rec.Id == model.Id);
                        if (element != null)
                        {
                            context.Students.Remove(element);
                            context.SaveChanges();
                        }
                        else
                        {
                            throw new Exception("Элемент не найден");
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public List<StudentViewModel> Read(StudentBindingModel model)
        {
            using (var context = new StudentDatabase())
            {
                return context.Students
                .Where(rec => model == null || rec.Id == model.Id)
                .ToList()
                .Select(rec => new StudentViewModel
                {
                    Id = rec.Id,
                    FIO = rec.FIO,
                    DatePostuplen = rec.DatePostuplenie,
                    Napravlenies = context.NapravlenieStudents
                    .Include(naps=>naps.Napravlenie)
                    .Where(naps=>naps.StudentId==rec.Id).ToDictionary(naps=>naps.NapravlenieId.ToString(), naps=>naps.Napravlenie.Name)
                })
                .ToList();
                /*
                 * context.NapravlenieStudents
                .Include(recPC => recPC.Napravlenie)
                .Where(recPC => recPC.StudentId == rec.Id)
                .ToDictionary(recPC => recPC.NapravlenieId, recPC => recPC.Napravlenie.Name)
                */
            }
        }
    }
}

