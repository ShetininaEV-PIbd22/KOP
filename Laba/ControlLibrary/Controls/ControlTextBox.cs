using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLibrary.Controls
{
    public partial class ControlTextBox : UserControl
    {
        public int? znachenie;
        
        public int? GetZnachenie
        {
            get 
            {
                try
                {
                    //Нажат checkBox
                    if (checkBox.Checked == true)
                    {
                        textBox.Text = "null";
                        znachenie = null;
                    }
                    //Нормальный ввод
                    else
                    {
                        
                        znachenie = Convert.ToInt32(textBox.Text);
                    }
                    return znachenie;
                }
                //Неверный формат
                catch (Exception)
                {
                    throw;
                    return -1;
                }
            }
        }
        public ControlTextBox()
        {
            InitializeComponent();
        }
    }
}
