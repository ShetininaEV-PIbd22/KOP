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

namespace ControlLibrary.Components
{
    public partial class ComponentWord : Component
    {
        Dictionary<int, int> rang= new Dictionary<int, int>();
        
        public ComponentWord()
        {
            InitializeComponent();
        }

        public ComponentWord(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void Check(int[] mas)
        {
            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i]- mas[i - 1] > 1)
                {
                    throw (new Exception("Неправильные номера столбцов!\nНомера должны идти по порядку. Индекс " + mas[i] 
                        + " не верен."));
                }
                mas[i - 1]--;
            }
        }
        public void IndexColumns(string [] buf)
        {
            for (int i = 0; i < buf.Length; i++)
            {
                int [] mas=buf[i].Split(',')
                  .Where(x => !string.IsNullOrWhiteSpace(x))
                  .Select(x => int.Parse(x)).ToArray();
                Array.Sort(mas);
                Check(mas);
                rang.Add(mas[0], mas[mas.Length - 1]);
            }
            
            if (rang.Count == 0)
            {
                throw (new Exception("Необходимы номера колонок для объединения")); 
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
            for (int i = 0; i < rang.Count; i++)
            {
                int start = rang.ElementAt(i).Key;
                int last = rang.ElementAt(i).Value;
                for (int j = start; j < last-1; j++)
                {
                    table.ElementAt(1).ElementAt(j).Append(FirstCells());
                    table.ElementAt(1).ElementAt(j+1).Append(SecondCells());
                }
            }
        }
        
        public void Save<T>(string fileName, List<T> list, List<string> names)
        {
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
