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
    public class NapravlenieLogic: INapravlenieLogic
    {
        public void CreateOrUpdate(NapravlenieBindingModel model)
        {
            using (var context = new StudentDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        Napravlenie element = context.Napravlenies.FirstOrDefault(rec => rec.Name == model.Name && rec.Id != model.Id);
                        if (element != null)
                        {
                            throw new Exception("Уже есть такое направление");
                        }
                        if (model.Id.HasValue)
                        {
                            element = context.Napravlenies.FirstOrDefault(rec => rec.Id == model.Id);

                            if (element == null)
                            {
                                throw new Exception("Элемент не найден");
                            }
                        }
                        else
                        {
                            element = new Napravlenie();
                            context.Napravlenies.Add(element);
                        }

                        element.Name = model.Name;
                        context.SaveChanges();
                        /*
                        if (model.Id.HasValue)
                        {
                            var shipComponents = context.NapravlenieStudents.Where(rec => rec.NapravlenieId == model.Id.Value).ToList();
                            context.NapravlenieStudents.RemoveRange(shipComponents.Where(rec => !model.Students.ContainsKey(rec.StudentId)).ToList());
                            context.SaveChanges();
                            foreach (var updateComponent in shipComponents)
                            {
                                updateComponent.Student.FIO =
                                model.Students[updateComponent.StudentId].Item1;

                                updateComponent.Student.DatePostuplenie=
                                model.Students[updateComponent.StudentId].Item2;
                                model.Students.Remove(updateComponent.StudentId);
                            }
                            context.SaveChanges();
                        }
                        foreach (var pc in model.Students)
                        {
                            context.NapravlenieStudents.Add(new NapravlenieStudent
                            {
                                NapravlenieId = element.Id,
                                StudentId = pc.Key,
                                //FIO = pc.Value.Item1,
                                //DatePostuplenie= pc.Value.Item2
                            });
                            context.SaveChanges();
                        }
                        */
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
        public void Delete(NapravlenieBindingModel model)
        {
            using (var context = new StudentDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.NapravlenieStudents.RemoveRange(context.NapravlenieStudents.Where(rec => rec.NapravlenieId == model.Id));
                        Napravlenie element = context.Napravlenies.FirstOrDefault(rec => rec.Id == model.Id);
                        if (element != null)
                        {
                            context.Napravlenies.Remove(element);
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
        public List<NapravlenieViewModel> Read(NapravlenieBindingModel model)
        {
            using (var context = new StudentDatabase())
            {
                return context.Napravlenies
                .Where(rec => model == null || rec.Id == model.Id)
                .ToList()
                .Select(rec => new NapravlenieViewModel
                {
                    Id = rec.Id,
                    Name = rec.Name
                    /*
                    Students = context.NapravlenieStudents
                .Include(recPC => recPC.Student)
                .Where(recPC => recPC.NapravlenieId == rec.Id)
                .ToDictionary(recPC => recPC.Id, recPC =>
                (recPC.Student.FIO, recPC.Student.DatePostuplenie))
                    */
                })
                .ToList();
            }
        }
    }
}
