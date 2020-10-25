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
    public partial class FormExcel : Form
    {
        public FormExcel()
        {
            InitializeComponent();
            comboBoxVertical.DataSource= Program.GetName<Class>();
            comboBoxVertical.SelectedItem = null;
        }
        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            if (textBoxTitle.Text == "")
            {
                MessageBox.Show("Введите названия сохранения. Сохраненный файл находится папке сохранения документов по умолочанию.");
                return;
            }
            componentExcel.name = folderBrowserDialog.SelectedPath+"\'"+textBoxTitle.Text;
            Console.WriteLine(componentExcel.name);
            if (comboBoxVertical.SelectedItem == null)
                {
                    MessageBox.Show("Введите названия колонок для постороения графика.");
                    return;
                }
                else
                {
                    componentExcel.index = comboBoxVertical.SelectedIndex;
                    if (textBoxName.Text == "")
                    {
                        DialogResult res=MessageBox.Show("Вы уверены, что хотите оставить название пустым?", "Вопрос",MessageBoxButtons.YesNo);
                        if (res == DialogResult.Yes)
                            componentExcel.title =" ";
                    else
                        return;
                    }
                    else
                        componentExcel.title= textBoxName.Text;
                    
                componentExcel.Open(Program.AddData(), Program.GetName<Class>(), "column");
            }
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            if (textBoxTitle.Text == "")
            {
                MessageBox.Show("Введите названия сохранения. Сохраненный файл находится папке сохранения документов по умолочанию.");
                return;
            }
            componentExcel.name = folderBrowserDialog.SelectedPath + "\\" + textBoxTitle.Text+ ".xlsx";
            Console.WriteLine(componentExcel.name);
            if (textBoxName.Text == "")
            {
                DialogResult res = MessageBox.Show("Вы уверены, что хотите оставить название пустым?", "Вопрос", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                    componentExcel.title = " ";
                else
                    return;
            }
            else
                componentExcel.title = textBoxName.Text;

            componentExcel.Open(Program.AddData(), Program.GetName<Class>(), "all");

        }
    }
}
