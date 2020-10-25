using Word=Microsoft.Office.Interop.Word;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Windows.Forms;
using System.Linq;

namespace ControlLibrary
{
    public partial class ComponentWord : Component
    {
        public int[][] mas { get; set; }
        
        public ComponentWord()
        {
            InitializeComponent();
        }

        public ComponentWord(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        
        public void IndexColumns()
        {
            Console.WriteLine("index");
            if (mas.Length == 0)
            {
                throw (new Exception("Необходимы номера колонок для объединения")); 
            }
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine("sort");
                Array.Sort(mas[i]);
                
                for (int j = 1; j < mas[i].Length; j++)
               {
                    Console.WriteLine("srav");
                    if (mas[i][j] - mas[i][j - 1] > 1)
                    {
                        throw (new Exception("Неправильные номера столбцов!\nНомера должны идти по порядку. Индекс " + mas[i][j] + " не верен."));
                    }
               }
               for (int k = 0; k < mas[i].Length; k++)
               {
                    mas[i][k] = mas[i][k] - 1;
                    Console.WriteLine("mas [" + i + "][" + k + "]= " + mas[i][k]);
               }
            }
        }
        
        private void PropertyTable(Table table)
        {
            //настройки таблицы для нормального отображения
            TableProperties tableProp = new TableProperties
            (
                new TableBorders
                (
                    new TopBorder
                    {
                        Val = new EnumValue<BorderValues>(BorderValues.Single),
                        Size = 12
                    },
                    new BottomBorder
                    {
                        Val = new EnumValue<BorderValues>(BorderValues.Single),
                        Size = 12
                    },
                    new LeftBorder
                    {
                        Val = new EnumValue<BorderValues>(BorderValues.Single),
                        Size = 12
                    },
                    new RightBorder
                    {
                        Val = new EnumValue<BorderValues>(BorderValues.Single),
                        Size = 12
                    },
                    new InsideHorizontalBorder
                    {
                        Val = new EnumValue<BorderValues>(BorderValues.Single),
                        Size = 12
                    },
                    new InsideVerticalBorder
                    {
                        Val = new EnumValue<BorderValues>(BorderValues.Single),
                        Size = 12
                    }
                )
            );
            TableWidth tableWidth = new TableWidth()
            {
                Width = "5000",
                Type = TableWidthUnitValues.Pct
            };
            tableProp.Append(tableWidth);
            table.Append(tableProp);
        }
        
        private void CreateTable<T>(Table table, List<T> list, List<string>names)
        {
            int count = 1;
            TableRow row = new TableRow();
            
            foreach (var name in names)
            {
                TableCell cell = new TableCell();
                cell.Append(new Paragraph(new Run(new Text(name))));
                row.Append(cell);
                count++;
            }
            table.Append(row);
            
            // создаем объект от типа
            object obj = Activator.CreateInstance(typeof(T));
            // вытаскиваем метод получения списка заголовков
            var method = typeof(T).GetMethod("Properties");
            // вызываем метод
            var config = (List<string>)method.Invoke(obj, null);

            foreach (var elem in list)
            {
                TableRow rows = new TableRow();
                foreach (string name in config)
                {
                    TableCell cells = new TableCell();
                    cells.Append(new Paragraph(new Run(new Text(elem.GetType().GetProperty(name).GetValue(elem).ToString()))));
                    rows.Append(cells);
                }
                table.Append(rows);
            }
        }

        private TableCellProperties FirstCells()
        {
            TableCellProperties cellOneProperties = new TableCellProperties();
            cellOneProperties.Append(new HorizontalMerge
            {
                Val = MergedCellValues.Restart
            });
            return cellOneProperties;
        }
        
        private TableCellProperties SecondCells()
        {
            TableCellProperties cellTwoProperties = new TableCellProperties();
            cellTwoProperties.Append(new HorizontalMerge
            {
                Val = MergedCellValues.Continue
            });
            return cellTwoProperties;
        }
        
        private void MergeCells(Table table)
        {
            int rows = mas.GetUpperBound(0) + 1;
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(mas[i][0]);
                table.ElementAt(1).ElementAt(mas[i][0]).Append(FirstCells());
                for (int j = 1; j < mas[i].Length; j++)
                {
                    table.ElementAt(1).ElementAt(mas[i][j]).Append(SecondCells());
                }
            }
        }
        
        public void Save<T>(string fileName, List<T> list, List<string> names)
        {
            if (File.Exists(fileName) == true)
            {
                File.Delete(fileName);
            }
            
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create
                (fileName, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());
                
                Paragraph para = body.AppendChild(new Paragraph());
                Run run = para.AppendChild(new Run());
                run.AppendChild(new Text("Таблица"));

                Table table = new Table();
                PropertyTable(table);
                CreateTable(table, list, names);
                
                MergeCells(table);
                mainPart.Document.Body.Append(table);
                mainPart.Document.Save();
            }
        }
    }
}
