using DocumentFormat.OpenXml;
//using DocumentFormat.OpenXml.Drawing;
//using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Packaging;
//using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLibrary
{
    public partial class ComponentExcel : Component
    {
        public int[] mas { get; set; }
        public int index { get; set; }
        public string title="";
        public string name { get; set; }
        public ComponentExcel()
        {
            InitializeComponent();
        }

        public ComponentExcel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        public void Open<T>(List<T> list, List<string> names, string typeDate) where T : class, new()
        {
            // Создаём экземпляр нашего приложения
            Application excelApp = new Application();
            excelApp.UserName = name+".xlsx";
            // Создаём экземпляр рабочий книги Excel
            Workbook workBook;
            // Создаём экземпляр листа Excel
            Worksheet workSheet;
            workBook = excelApp.Workbooks.Add();
            workSheet = (Worksheet)workBook.Worksheets.get_Item(1);

            Type type = typeof(T);
            // создаем объект от типа
            object obj = Activator.CreateInstance(type);
            // вытаскиваем метод получения списка заголовков
            var method = type.GetMethod("Properties");
            // вызываем метод
            var config = (List<string>)method.Invoke(obj, null);
            int count = 1;//количество столбцов
            foreach (var name in names)
            {
                workSheet.Cells[1, count] = name;
                count++;
            }
            int j = 2;// строка
            foreach (var elem in list)
            { 
                int i = 1;//столбец
                foreach (var conf in config)
                {
                    workSheet.Cells[j, i] = elem.GetType().GetProperty(conf).GetValue(elem);
                    i++;
                }
                j++;
            }
            ChartObjects chartObjs = (ChartObjects)workSheet.ChartObjects();
            ChartObject chartObj = chartObjs.Add(250, 50, 300, 300);
            
            Chart xlChart = chartObj.Chart;
            
            if (title =="")
            {
                xlChart.HasTitle = false;
            }
            else
            {
                xlChart.HasTitle = true;
                xlChart.ChartTitle.Text = title;
            }
            // Устанавливаем тип диаграммы
            xlChart.ChartType = XlChartType.xlColumnClustered;
            //xl3DColumn;

            //диапазон данных
            Range range = null;
            if (typeDate == "all")
            {
                range = workSheet.Range[workSheet.Cells[1, 1], workSheet.Cells[(j - 1), (count - 1)]];
            }
            else if (typeDate == "column")
            {
                range = workSheet.Range[workSheet.Cells[1, index + 1], workSheet.Cells[(j - 1), index + 1]];
            }
            
            // Устанавливаем источник данных 
            xlChart.SetSourceData(range);

            //Открываем созданный excel-файл
            excelApp.Visible = true;
            excelApp.UserControl = true;
            Console.WriteLine("save");
            excelApp.Application.ActiveWorkbook.Saved = true;
            excelApp.Application.ActiveWorkbook.SaveAs(@name);//"C:\Users\sheti\Desktop\KOPlaba1.xlsx" name);
        }
    }
}
