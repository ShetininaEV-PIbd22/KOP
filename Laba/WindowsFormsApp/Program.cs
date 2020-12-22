using ControlLibrary;
using Database.Implements;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace WindowsFormsApp
{
    public static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormStudents>());
        }
        
        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<INapravlenieLogic, NapravlenieLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IStudentLogic, StudentLogic>(new HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}

