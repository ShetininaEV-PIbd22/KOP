using Library.Interfaces;
using System;
using System.Linq;
using Library.BindingModels;
using System.Windows.Forms;
using Unity;
using Library.ViewModels;
using System.Collections.Generic;

namespace WindowsFormsApp
{
    public partial class FormStudents : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IStudentLogic logic;
        private readonly INapravlenieLogic logicN;

        public FormStudents(IStudentLogic logic, INapravlenieLogic logicN)
        {
            InitializeComponent();
            this.logic = logic;
            this.logicN = logicN;
        }
        private void LoadData()
        {
            var students = logic.Read(null);
            List<string> result= new List<string>();
            result.Add("ФИО; Дата поступления; Направления");
            result.Add("------------------------------------------------------------------");
            foreach (var s in students)
            {
                string nap = "";
                foreach (var n in s.Napravlenies)
                {
                    nap += n.Value+", ";
                }
                result.Add(s.FIO + "; " + s.DatePostuplen.Date+"; "+nap);
            }
            controlListBox.LoadList(result);
        }

        private void FormStudents_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormStudent>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            if (controlListBox.SelectedIndex >= 0)
            {
                var form = Container.Resolve<FormStudent>();
                form.FIO = controlListBox.SelectedText.Split(';')[0];
                if (form.ShowDialog() == DialogResult.OK)
                    LoadData();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (controlListBox.SelectedIndex >= 0)
                {
                    string fio = controlListBox.SelectedText.Split(';')[0];
                    DialogResult res=MessageBox.Show("Вы уверены, что хотите удалить студента " + fio + "?", "Вопрос", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        int id = logic.Read(null).FirstOrDefault(rec => rec.FIO == fio).Id;
                        logic.Delete(new StudentBindingModel { Id = id });
                        LoadData();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void сохранитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var students = logic.Read(null);
                folderBrowserDialog.ShowDialog();
                componentStore.SaveData(folderBrowserDialog.SelectedPath + "\\", logic.Read(null));
                MessageBox.Show("Готово!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void добавитьНаправлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form= Container.Resolve<FormMain>();
            form.ShowDialog();
        }

        private void списокСтудентовСНаправлениямиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, Dictionary<string, string>> res = new Dictionary<string, Dictionary<string, string>>();
                var students = logic.Read(null);
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
                var students = logic.Read(null).GroupBy(rec => rec.DatePostuplen.Year)
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialog.ShowDialog();
                componentStore.SaveData(folderBrowserDialog.SelectedPath + "\\", logicN.Read(null));
                MessageBox.Show("Готово!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
