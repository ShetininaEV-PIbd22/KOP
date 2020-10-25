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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonControlListBox_Click(object sender, EventArgs e)
        {
            FormControlListBox list = new FormControlListBox();
            list.ShowDialog();
        }

        private void buttonControlTextBox_Click(object sender, EventArgs e)
        {
            FormControlTextBox text = new FormControlTextBox();
            text.ShowDialog();
        }

        private void buttonControlDataGridView_Click(object sender, EventArgs e)
        {
            FormControlDataGridView data = new FormControlDataGridView();
            data.ShowDialog();
        }

        private void buttonFormStore_Click(object sender, EventArgs e)
        {
            FormStore store = new FormStore();
            store.ShowDialog();
        }

        private void buttonFormWord_Click(object sender, EventArgs e)
        {
            FormWord word = new FormWord();
            word.ShowDialog();
        }

        private void buttonFormExcel_Click(object sender, EventArgs e)
        {
            FormExcel excel = new FormExcel();
            excel.ShowDialog();
        }
    }
}
