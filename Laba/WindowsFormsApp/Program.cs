using ControlLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
        
        public static List<MyClass> AddData()
        {
            List<MyClass> list = new List<MyClass>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new MyClass
                {
                    id = i,
                    Text = "Объект" + (i + 1),
                    Name = "Имя" + (i + 1),
                    Phone = "897654" + i,
                    Age = i + 10
                }) ;
            }
            return list;

        }
        
        public static List<string> GetName<T>()
        {
            List<string> result = new List<string>();

            Type type = typeof(T);
            // создаем объект от типа
            object obj = Activator.CreateInstance(type);
            // вытаскиваем метод получения списка заголовков
            var method = type.GetMethod("Properties");
            // вызываем метод
            var config = (List<string>)method.Invoke(obj, null);
            foreach (var conf in config)
            {
                // вытаскиваем нужное свойство из класса
                var prop = type.GetProperty(conf);
                if (prop != null)
                {
                    // получаем список атрибутов
                    var attributes = prop.GetCustomAttributes(typeof(ColumnAttribute), true);
                    if (attributes != null && attributes.Length > 0)
                    {
                        foreach (var atr in attributes)
                        {
                            if (atr is ColumnAttribute columnAttr)
                            {
                                Console.WriteLine(columnAttr.Title);
                                result.Add(columnAttr.Title);
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
