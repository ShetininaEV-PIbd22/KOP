using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormWord : Form
    {
        public FormWord()
        {
            InitializeComponent();
        }
        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string[] num = textBox1.Text.Split(';')
                        .Where(x => !string.IsNullOrWhiteSpace(x)).ToArray(); ;
                int[][] buf = new int[num.Length][];
                for (int i = 0; i < num.Length; i++)
                {
                    buf[i] = num[i].Split(',')
                      .Where(x => !string.IsNullOrWhiteSpace(x))
                      .Select(x => int.Parse(x)).ToArray();
                    for (int j = 0; j < buf.Length; j++)
                    {
                        Console.WriteLine("buf " + i + " " + j + "= " + buf[i][j]);
                    }
                }

                componentWord.mas = buf;
                componentWord.IndexColumns();
                folderBrowserDialog.ShowDialog();
                componentWord.Save(folderBrowserDialog.SelectedPath + "\\laba.docx", Program.AddData(), Program.GetName<Class>());
                MessageBox.Show("Успешно!");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Ошибка! " + ex.Message);
                MessageBox.Show("Не верный формат индексов. Для разделения разных объединений используйте ;. " +
                    "Для разделения индексов для одного объединения используйте ,");
            }

        }
    }
}
