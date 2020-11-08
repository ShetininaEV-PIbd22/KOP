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
                if (textBoxName.TextLength == 0)
                {
                    MessageBox.Show("Введите имя файла!");
                    return;
                }
                string[] num = textBox1.Text.Split(';')
                        .Where(x => !string.IsNullOrWhiteSpace(x)).ToArray(); ;
                componentWord.IndexColumns(num);
                folderBrowserDialog.ShowDialog();
                componentWord.Save(folderBrowserDialog.SelectedPath + "\\"+textBoxName.Text+".docx", Program.AddData(), Program.GetName<MyClass>());
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
