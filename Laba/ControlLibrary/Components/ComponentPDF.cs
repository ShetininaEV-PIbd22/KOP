using System;
using System.Collections.Generic;
using System.ComponentModel;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes.Charts;
using MigraDoc.Rendering;

namespace ControlLibrary.Components
{
    public partial class ComponentPDF : Component
    {
        public ComponentPDF()
        {
            InitializeComponent();
        }

        public ComponentPDF(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        public void CreateDocument(String FileName, Dictionary<int, string> data)
        {
            Console.WriteLine(FileName);
            Document document = new Document();
            Section section = document.AddSection();

            Chart chart = new Chart(ChartType.Line);
            chart.Width = "10cm";
            chart.Height = "10cm";
            Series series = chart.SeriesCollection.AddSeries();
            Console.WriteLine(data.Count);
            foreach (KeyValuePair<int, string> keyValue in data)
            {
                series.Add(keyValue.Key);
            }

            XSeries xseries = chart.XValues.AddXSeries();

            foreach (KeyValuePair<int, string> keyValue in data)
            {
                xseries.Add(keyValue.Value);
            }

            chart.XAxis.MajorTickMark = TickMarkType.Outside;
            chart.XAxis.Title.Caption = "X-Axis";
            chart.YAxis.MajorTickMark = TickMarkType.Outside;
            chart.YAxis.HasMajorGridlines = true;
            chart.PlotArea.LineFormat.Color = Colors.AliceBlue;
            chart.PlotArea.LineFormat.Width = 1;
            chart.PlotArea.LineFormat.Visible = true;

            section.Add(chart);
            PdfDocumentRenderer renderer = new PdfDocumentRenderer(true, PdfSharp.Pdf.PdfFontEmbedding.Automatic)
            {
                Document = document
            };
            renderer.RenderDocument();
            renderer.PdfDocument.Save(FileName);
        }
    }
}

