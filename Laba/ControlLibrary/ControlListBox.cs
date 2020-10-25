using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class ControlListBox : UserControl
    {
        // Порядковый номер выбранного элемента
        private int _selectedIndex;
        public string _selectedText;
        // Событие выбора элемента из списка
        
        // Порядковый номер выбранного элемента
        [Category("Студент"), Description("Порядковый номер выбранного элемента")]
        
        public int SelectedIndex
        {
            get 
            {
                _selectedIndex= listBox.SelectedIndex;
                return _selectedIndex;
            }
            set { if (value > -2 && value < listBox.Items.Count) 
                { 
                    _selectedIndex = value; 
                    listBox.SelectedIndex = _selectedIndex; 
                } 
            }
        }
        
        // Текст выбранной записи
        [Category("Студент"), Description("Текст выбранной записи")]
        public string SelectedText
        {
            get 
            {
                _selectedText= listBox.Text;
                return _selectedText;
            }
            set 
            { 
                _selectedText = value;
                listBox.Text = _selectedText;
            }
        }
        
        // Конструктор
        public ControlListBox()
        {
            InitializeComponent();
        }
        
        // Заполнение списка значениями из справочника
        public void LoadList(List<string> students)
        {
            for (int i=0; i<students.Count; i++)
            {
                listBox.Items.Add(students[i].ToString());
            }
        }
    }
}
