using Library.BindingModels;
using Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Interfaces
{
    public interface INapravlenieLogic
    {
        void CreateOrUpdate(NapravlenieBindingModel model);
        void Delete(NapravlenieBindingModel model);
        List<NapravlenieViewModel> Read(NapravlenieBindingModel model);
    }
}
