using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormControlListBox : Form
    {
        public FormControlListBox()
        {
            InitializeComponent();
            Students students = new Students();
            controlListBox.LoadList(students.LoadData());
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            if (controlListBox.SelectedText =="")
            {
                MessageBox.Show("Выберите студента");
                return;
            }
            Console.WriteLine("Index= " + controlListBox.SelectedIndex);
            string date = "Индекс студента: " + controlListBox.SelectedIndex.ToString() +
                "\n ФИО студента: " + controlListBox.SelectedText;
            MessageBox.Show(date);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddStudent add = new FormAddStudent();
            add.ShowDialog();
            controlListBox.LoadList(add.fio.Split(' ').ToList());
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (controlListBox.SelectedText == "")
            {
                MessageBox.Show("Выберите студента");
                return;
            }
            FormUpdateStudent upd = new FormUpdateStudent(controlListBox);
            upd.LoadData(controlListBox.SelectedIndex, controlListBox.SelectedText);
            upd.ShowDialog();
            controlListBox.Refresh();
        }
    }
}
