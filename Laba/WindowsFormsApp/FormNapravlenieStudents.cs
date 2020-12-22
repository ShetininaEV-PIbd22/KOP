using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.BindingModels;
using System.Windows.Forms;
using Unity;

namespace WindowsFormsApp
{
    public partial class FormNapravlenieStudents : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        public string NameN { set { name = value; } }

        private readonly INapravlenieLogic logicN;
        private readonly IStudentLogic logicS;
        private int? id;
        private string name;

        public FormNapravlenieStudents(INapravlenieLogic logicN, IStudentLogic logicS)
        {
            InitializeComponent();
            this.logicN = logicN;
            this.logicS = logicS;
        }

        private void FormNapravlenieStudents_Load(object sender, EventArgs e)
        {
            id = logicN.Read(null).FirstOrDefault(rec => rec.Name == name).Id;
            textBoxName.Text = logicN.Read(new NapravlenieBindingModel { Id = id })?[0].Name;
            var students = logicS.Read(null)
                .Where(rec=>rec.Napravlenies.ContainsKey(id.Value.ToString())==true).ToList();
            
            List<string> result = new List<string>();
            result.Add("ФИО; Дата поступления");
            result.Add("--------------------------------------------------");

            foreach (var s in students)
            {
                result.Add(s.FIO + "; " + s.DatePostuplen.Date);
            }
            controlListBox.LoadList(result);
        }
    }
}
