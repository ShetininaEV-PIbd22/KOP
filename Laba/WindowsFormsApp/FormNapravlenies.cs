using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace WindowsFormsApp
{
    public partial class FormNapravlenies : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly INapravlenieLogic logic;
        
        public string Id
        {
            get { return GetId(); }
            set { controlListBox.SelectedIndex = Convert.ToInt32(value); }
        }

        public string NapravlenieName{ get { return controlListBox.SelectedText; } }

        public FormNapravlenies(INapravlenieLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }
        private void LoadData()
        {
            var napravlenies = logic.Read(null).Select(rec => rec.Name).ToList(); 
            controlListBox.LoadList(napravlenies);
        }
        private void FormNapravlenies_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        private string GetId()
        {
            Console.WriteLine(controlListBox.SelectedText);
            return logic.Read(null).FirstOrDefault(rec => rec.Name == controlListBox.SelectedText.Split(';')[0]).Id.Value.ToString();
        }
    }
}
