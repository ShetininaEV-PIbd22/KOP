using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace WindowsFormsApp
{
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly INapravlenieLogic logicN;
        private readonly IStudentLogic logicS;

        public FormMain(INapravlenieLogic logicN, IStudentLogic logicS)
        {
            InitializeComponent();
            this.logicN = logicN;
            this.logicS = logicS;
            LoadData();
        }
        private void LoadData()
        {
            var napravlenies = logicN.Read(null).Select(rec => rec.Name).ToList();
            controlListBox.LoadList(napravlenies);
        }

        private void добавитьНаправлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormNapravlenie>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormStudents>();
            form.ShowDialog();
        }

        private void изменитьНToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (controlListBox.SelectedIndex>=0)
            {
                var form = Container.Resolve<FormNapravlenie>();
                form.NameNap = controlListBox.SelectedText.Split(';')[0];
                if (form.ShowDialog() == DialogResult.OK)
                    LoadData();
            }
            else
            {
                MessageBox.Show("Выберете направление.");
            }
        }

        private void списокСтудентовНаЭтомНаправленииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (controlListBox.SelectedIndex >= 0)
            {
                var form = Container.Resolve<FormNapravlenieStudents>();
                form.NameN = controlListBox.SelectedText.Split(';')[0];
                if (form.ShowDialog() == DialogResult.OK)
                    LoadData();
            }
            else 
            {
                MessageBox.Show("Выберете направление.");
            }
        }

        private void сохранитьДанныеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialog.ShowDialog();
                componentStore.SaveData(folderBrowserDialog.SelectedPath + "\\", logicN.Read(null));
                //componentStore.Save(folderBrowserDialog.SelectedPath + "\\", logicN.Read(null));

                MessageBox.Show("Готово!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void открытьСписокВсехСтудентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormStudents>();
            form.ShowDialog();
        }

        private void сохранитьДанныеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try 
            {
                var students = logicS.Read(null);
                folderBrowserDialog.ShowDialog();
                componentStore.SaveData(folderBrowserDialog.SelectedPath + "\\", logicS.Read(null));
                MessageBox.Show("Готово!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void студентыСНаправлениямиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, Dictionary<string, string>> res = new Dictionary<string, Dictionary<string,string>>();
                var students = logicS.Read(null);
                foreach (var stud in students)
                {
                    res.Add(stud.FIO, stud.Napravlenies);
                }
                saveFileDialog.ShowDialog();
                componentPdfReport.CreateDocument(saveFileDialog.FileName + ".pdf", res);
                MessageBox.Show("Готово!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void диаграммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<int, string> res = new Dictionary<int, string>();
                var students = logicS.Read(null).GroupBy(rec => rec.DatePostuplen.Year)
                    .ToDictionary(rec => rec.Count(), rec => rec.Key.ToString());
                /*
                foreach (var s in students)
                {
                    Console.WriteLine(s.Key + "-" + s.Value);
                }
                */
                saveFileDialog.ShowDialog();
                componentPDF.CreateDocument(saveFileDialog.FileName + ".pdf", students);
                MessageBox.Show("Готово!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
