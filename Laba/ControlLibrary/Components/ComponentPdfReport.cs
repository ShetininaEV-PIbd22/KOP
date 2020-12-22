using System;
using System.Collections.Generic;
using System.ComponentModel;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using System.Text;

namespace ControlLibrary.Components
{
    public partial class ComponentPdfReport : Component
    {
        public ComponentPdfReport()
        {
            InitializeComponent();
        }

        public ComponentPdfReport(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        //, Dictionary<string, string> data
        public void CreateDocument(String FileName, Dictionary<string, Dictionary<string, string>> data)
        {
            Console.WriteLine(data.Count);
            Document document = new Document();
            DefineStyles(document);

            Section section = document.AddSection();
            Paragraph paragraph = section.AddParagraph();
            paragraph.Format.SpaceAfter = "1cm";
            paragraph.Format.Alignment = ParagraphAlignment.Center;
            paragraph.Style = "NormalTitle";

            var table = document.LastSection.AddTable();
            List<string> columns = new List<string> { "8cm", "6cm"};

            foreach (var elem in columns)
            {
                table.AddColumn(elem);
            }

            CreateRow(new PdfRowParameters
            {
                Table = table,
                Texts = new List<string> { "ФИО студента", "Название направления"},
                Style = "NormalTitle",
                ParagraphAlignment = ParagraphAlignment.Center
            });

            foreach (var d in data)
            {
                foreach (var v in d.Value)
                {
                    CreateRow(new PdfRowParameters
                    {
                        Table = table,
                        Texts = new List<string>
                        {
                            d.Key,
                            v.Value,
                        },
                        Style = "Normal",
                        ParagraphAlignment = ParagraphAlignment.Left
                    });
                }
            }

            PdfDocumentRenderer renderer = new PdfDocumentRenderer(true, PdfSharp.Pdf.PdfFontEmbedding.Always)
            {
                Document = document
            };
            renderer.RenderDocument();
            renderer.PdfDocument.Save(FileName);
        }

        private static void DefineStyles(Document document)
        {
            Style style = document.Styles["Normal"];
            style.Font.Name = "Times New Roman";
            style.Font.Size = 14;
            style = document.Styles.AddStyle("NormalTitle", "Normal");
            style.Font.Bold = true;
        }

        private static void CreateRow(PdfRowParameters rowParameters)
        {
            Row row = rowParameters.Table.AddRow();

            for (int i = 0; i < rowParameters.Texts.Count; ++i)
            {
                FillCell(new PdfCellParameters
                {
                    Cell = row.Cells[i],
                    Text = rowParameters.Texts[i],
                    Style = rowParameters.Style,
                    BorderWidth = 0.5,
                    ParagraphAlignment = rowParameters.ParagraphAlignment
                });
            }
        }

        private static void FillCell(PdfCellParameters cellParameters)
        {
            cellParameters.Cell.AddParagraph(cellParameters.Text);

            if (!string.IsNullOrEmpty(cellParameters.Style))
            {
                cellParameters.Cell.Style = cellParameters.Style;
            }

            cellParameters.Cell.Borders.Left.Width = cellParameters.BorderWidth;
            cellParameters.Cell.Borders.Right.Width = cellParameters.BorderWidth;
            cellParameters.Cell.Borders.Top.Width = cellParameters.BorderWidth;
            cellParameters.Cell.Borders.Bottom.Width = cellParameters.BorderWidth;
            cellParameters.Cell.Format.Alignment = cellParameters.ParagraphAlignment;
            cellParameters.Cell.VerticalAlignment = VerticalAlignment.Center;
        }
    }
}
