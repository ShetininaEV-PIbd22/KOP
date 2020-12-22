using Library.BindingModels;
using Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Interfaces
{
    public interface IStudentLogic
    {
        void CreateOrUpdate(StudentBindingModel model);
        void Delete(StudentBindingModel model);
        List<StudentViewModel> Read(StudentBindingModel model);
    }
}
