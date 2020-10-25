using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLibrary
{
    public class ColumnAttribute : Attribute
    {
        public ColumnAttribute (string title = "", bool visible = true, int width = 0, DataGridViewAutoSizeColumnMode gridViewAutoSize = DataGridViewAutoSizeColumnMode.None)
        {
            Title = title;
            Visible = visible;
            Width = width;
            AutoSize = gridViewAutoSize;
        }
        public string Title { get; private set; }
        public bool Visible { get; private set; }
        public int Width { get; private set; }
        public DataGridViewAutoSizeColumnMode AutoSize { get; private set; }
    }
}
