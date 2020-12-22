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
    public partial class DateControl : UserControl
    {
        public DateTime SelectedValue{ get{ return GetDateValue(); } set { dateTimePicker.Value = value; } }
        public DateControl()
        {
            InitializeComponent();
        }
        private DateTime GetDateValue()
        {
            if (dateTimePicker.Value.Date == null)
            {
                throw (new Exception("Заполните поле!"));
            }
            if (dateTimePicker.Value.Year <= DateTime.Now.Year && dateTimePicker.Value.Year >= (DateTime.Now.Year - 2))
            {
                return dateTimePicker.Value.Date;
            }
            else
            {
                throw (new Exception("Значение находится вне диапазона."));
            }
        }
    }
}
