using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
        public static List<Class> AddData()
        {
            List<Class> list = new List<Class>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new Class
                {
                    id = i,
                    Text = "Объект" + (i + 1),
                    Phone = "897654" + i
                });
            }
            return list;
        }
    }
}
