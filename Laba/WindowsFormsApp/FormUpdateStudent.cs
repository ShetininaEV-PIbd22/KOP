using ControlLibrary;
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
    public partial class FormUpdateStudent : Form
    {
        ControlListBox clb;
        public FormUpdateStudent(ControlListBox clb)
        {
            InitializeComponent();
            this.clb = clb;
        }
        public void LoadData(int index, string fio)
        {
            textBoxIndex.Text = index.ToString();
            textBoxFIO.Text = fio;
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(textBoxIndex.Text);
            string fio = textBoxFIO.Text;
            //clb.Chenge(index, fio);
            Close();
        }

        private void buttonCansel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
