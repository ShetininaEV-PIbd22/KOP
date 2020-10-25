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
    public partial class FormControlTextBox : Form
    {
        public FormControlTextBox()
        {
            InitializeComponent();
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            int? znach = controlTextBox.GetZnachenie;
            Console.WriteLine("zanch= " + znach);
            if (znach!=-1)
            {
                MessageBox.Show("Введенное значение: " + znach);
            }
            if (znach == -1)
            {
                MessageBox.Show("Ошибка!");
            }
        }
    }
}
