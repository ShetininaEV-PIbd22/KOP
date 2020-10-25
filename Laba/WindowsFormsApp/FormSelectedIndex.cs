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
    public partial class FormSelectedIndex : Form
    {
        public int index
        {
            get;
            set;
        }
        public FormSelectedIndex()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            index = Convert.ToInt32(textBoxIndex.Text);
            Close();
        }

        private void buttonCansel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
