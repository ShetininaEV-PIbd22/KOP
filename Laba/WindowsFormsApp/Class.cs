using ControlLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public class Class
    {
        [Column(title: "ID!", width: 40, visible:false)]
        public int id { get; set; }
        //gridViewAutoSize: DataGridViewAutoSizeColumnMode.Fill
        
        [Column(title: "Текст", width:100)]
        public string Text { get; set; }
        
        [Column(title: "Телефон", width: 100)]
        public string Phone { get; set; }

        
        
        public List<string> Properties() => new List<string> 
        { "id", 
          "Text", 
          "Phone"
        };
    }
}
