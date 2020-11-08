using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            comboBoxVertical.DataSource = Program.GetName<MyClass>();
            comboBoxVertical.SelectedItem = null;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialog.ShowDialog();
                //Сохраненный файл находится папке сохранения документов по умолочанию.
                if (textBoxTitle.Text == "")
                {
                    MessageBox.Show("Введите названия сохранения.");
                    return;
                }
                
                componentExcel.filePath = folderBrowserDialog.SelectedPath + "\\" + textBoxTitle.Text + ".xlsx";
                Console.WriteLine("path= " + componentExcel.filePath);

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
                        DialogResult res = MessageBox.Show("Вы уверены, что хотите оставить название пустым?", "Вопрос", MessageBoxButtons.YesNo);
                        if (res == DialogResult.Yes)
                            componentExcel.title = " ";
                        else
                            return;
                    }
                    else
                        componentExcel.title = textBoxName.Text;

                    componentExcel.Open(Program.AddData(), Program.GetName<MyClass>(), "column");
                    MessageBox.Show("Успешно!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonAll_Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialog.ShowDialog();
                if (textBoxTitle.Text == "")
                {
                    MessageBox.Show("Введите названия сохранения.");
                    return;
                }
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

                componentExcel.filePath = folderBrowserDialog.SelectedPath + "\\" + textBoxTitle.Text + ".xlsx";
                Console.WriteLine(componentExcel.filePath);

                componentExcel.Open(Program.AddData(), Program.GetName<MyClass>(), "all");
                MessageBox.Show("Успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
