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
    public partial class FormAddStudent : Form
    {
        public string fio
        {
            get;
            set;
        }
        public FormAddStudent()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            fio =textBoxFIO.Text;
            Close();
        }

        private void buttonCansel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
