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
    public partial class FormControlDataGridView : Form
    {
        public FormControlDataGridView()
        {
            InitializeComponent();
            controlDataGridView.LoadData(Program.AddData());
        }

        private void buttonGetIndex_Click(object sender, EventArgs e)
        {
            int index = controlDataGridView.SelectedIndex;
            if (index <= -1 || index > controlDataGridView.GetCountRows)
            {
                MessageBox.Show("Строка не выбранна.");
                return;
            }
            MessageBox.Show("Индекс выбранной строки: " +index);
        }

        private void buttonSetIndex_Click(object sender, EventArgs e)
        {
            FormSelectedIndex f = new FormSelectedIndex();
            f.ShowDialog();
            controlDataGridView.SelectedIndex=f.index;
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ссылка на выбранную строку: "+controlDataGridView.GetRef);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddStudent form = new FormAddStudent();
            form.ShowDialog();
            controlDataGridView.LoadData(form.fio.Split(' ').ToList());
        }
    }
}
