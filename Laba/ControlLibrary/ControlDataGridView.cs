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
    public partial class ControlDataGridView : UserControl
    {
        private int index;

        public int SelectedIndex
        {
            get
            {
                index = dataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                return index;
            }
            set
            {
                index = value;
                dataGridView.Rows[index].Selected = true;
            }
        }
        public string GetRef
        {
            get
            {
                DataGridViewSelectedRowCollection result = dataGridView.SelectedRows;
                //DataGridViewRow result =dataGridView.CurrentRow;
                return result.ToString();
            }
        }
        public int GetCountRows
        {
            get { return dataGridView.Rows.Count; }
        }

        public ControlDataGridView()
        {
            InitializeComponent();

        }

        public void LoadData<T>(List<T> list)
        {
            var type = typeof(T);
            // создаем объект от типа
            object obj = Activator.CreateInstance(type);
            // вытаскиваем метод получения списка заголовков
            var method = type.GetMethod("Properties");
            // вызываем метод
            var config = (List<string>)method.Invoke(obj, null);
            dataGridView.Columns.Clear();
            foreach (var conf in config)
            {
                // вытаскиваем нужное свойство из класса
                var prop = type.GetProperty(conf);
                if (prop != null)
                {
                    // получаем список атрибутов
                    var attributes = prop.GetCustomAttributes(typeof(ColumnAttribute), true);
                    if (attributes != null && attributes.Length > 0)
                    {
                        foreach (var attr in attributes)
                        {
                            // ищем нужный нам атрибут
                            if (attr is ColumnAttribute columnAttr)
                            {
                                var column = new DataGridViewTextBoxColumn
                                {
                                    Name = conf,
                                    ReadOnly = true,
                                    HeaderText = columnAttr.Title,
                                    Visible = columnAttr.Visible,
                                    Width = columnAttr.Width
                                };
                                if (columnAttr.AutoSize != DataGridViewAutoSizeColumnMode.None)
                                {
                                    column.AutoSizeMode = (DataGridViewAutoSizeColumnMode)Enum.Parse(typeof(DataGridViewAutoSizeColumnMode), 
                                        columnAttr.AutoSize.ToString());
                                }
                                dataGridView.Columns.Add(column);
                            }
                        }
                    }
                }
            }
            // добавляем строки
            foreach (var elem in list)
            {
                List<object> objs = new List<object>();
                foreach (var conf in config)
                {
                    var value = elem.GetType().GetProperty(conf).GetValue(elem);
                    objs.Add(value);
                }
                dataGridView.Rows.Add(objs.ToArray());
            }
        }
    }
}
