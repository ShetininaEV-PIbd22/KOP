using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormStore : Form
    {
        
        public FormStore()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialog.ShowDialog();
                Console.WriteLine(folderBrowserDialog.SelectedPath);
                componentStore.SaveData(folderBrowserDialog.SelectedPath+"\\"
                    , Program.AddData());
                MessageBox.Show("Готово!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка. "+ex.Message.ToString());
            }
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            string st = "";
            foreach (var l in componentStore.GetData())
            {
                Console.WriteLine(l);
                st = st + "\n" + l;
            }
            textBox1.Text = st;
        }
    }
}
