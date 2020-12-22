using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class CheckBoxControl : UserControl
    {
        // Порядковый номер выбранного элемента
        private int[] _selectedIndex;
        public string[] _selectedText;
        // Событие выбора элемента из списка

        // Порядковый номер выбранного элемента
        [Category("Студент"), Description("Порядковый номер выбранного элемента")]

        public int[] SelectedIndex
        {
            get
            {
                for (int i = 0; i < checkedListBox.CheckedIndices.Count; i++)
                {
                    _selectedIndex[i] = Convert.ToInt32(checkedListBox.CheckedIndices[i].ToString());
                }
                return _selectedIndex;
            }
            set
            {
                if (value != null)
                {
                    if (value.Length > -2 && value.Length < checkedListBox.Items.Count)
                    {
                        _selectedIndex = value;
                        for (int i = 0; i < value.Length; i++)
                        {
                            checkedListBox.SetItemChecked(i, true);
                        }
                    }
                }
            }
        }

        // Текст выбранной записи
        [Category("Студент"), Description("Текст выбранной записи")]
        public string[] SelectedText
        {
            get
            {
                _selectedText = new string[checkedListBox.SelectedItems.Count];
                Console.WriteLine("checked=" + checkedListBox.SelectedItems.Count);
                for (int i = 0; i < checkedListBox.SelectedItems.Count; i++)
                {
                    _selectedText[i] = checkedListBox.SelectedItems[i].ToString();
                }
                return _selectedText;
            }
            set
            {
                _selectedText = value;
                for (int i = 0; i < value.Length; i++)
                {
                    for (int j = 0; j < checkedListBox.Items.Count; j++)
                    {
                        Console.WriteLine("value=" + value[i]);
                        Console.WriteLine(checkedListBox.Items[j].ToString());
                        if (checkedListBox.Items[j].ToString() == value[i])
                        {
                            checkedListBox.SetItemChecked(j, true);
                        }
                    }
                }
            }
        }

        public CheckBoxControl()
        {
            InitializeComponent();
        }
        // Заполнение списка значениями из справочника
        public void LoadList<T>(List<T> list)
        {
            checkedListBox.Items.Clear();
            /*
            var prop = typeof(T).GetProperties();
            Console.WriteLine(prop.Length);
            for (int i = 0; i < list.Count; i++)
            {
                string data = "";
                for (int j = 0; j < prop.Length; j++)
                {
                    data += prop[j].GetValue(list[i]) + "; ";
                }
                data += "\n";
                listBox.Items.Add(data);
            }
            */
            for (int i = 0; i < list.Count; i++)
            {
                checkedListBox.Items.Add(list[i]);
            }
        }
    }
}

