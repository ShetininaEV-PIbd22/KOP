using Library.BindingModels;
using Library.Interfaces;
using Library.ViewModels;
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
    public partial class FormStudent : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public string FIO { set { fio = value; }}
        private readonly IStudentLogic logic;
        private readonly INapravlenieLogic logicN;

        private int? id;
        private string fio;
        private Dictionary<string, string> napravlenie;

        public FormStudent(IStudentLogic logic, INapravlenieLogic logicN)
        {
            InitializeComponent();
            this.logic = logic;
            this.logicN = logicN;
            
        }

        private void buttonAddNaprav_Click(object sender, EventArgs e)
        {
            /*
            var form = Container.Resolve<FormNapravlenies>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (napravlenie.ContainsKey(form.Id))
                {
                    napravlenie[form.Id] = form.NapravlenieName;
                }
                else
                {
                    napravlenie.Add(form.Id, form.NapravlenieName);
                }
                LoadData();
            }
            */
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkBoxControl.SelectedText.Length; i++)
            {
                string name = checkBoxControl.SelectedText[i];
                string napID = logicN.Read(null).FirstOrDefault(rec => rec.Name == name).Id.Value.ToString();
                if (napravlenie.ContainsKey(napID))
                {
                    napravlenie[napID] = name;
                }
                else
                {
                    napravlenie.Add(napID, name);
                }
                //napravlenie.Add(napID, checkBoxControl.SelectedText[i]);
            }
            if (string.IsNullOrEmpty(textBoxFIO.Text))
            {
                MessageBox.Show("Заполните ФИО", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateControl.SelectedValue == null)
            {
                MessageBox.Show("Заполните дату поступления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (napravlenie == null || napravlenie.Count == 0)
            {
                MessageBox.Show("Заполните направления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /*
            Console.WriteLine("Save id=" + id);
            Console.WriteLine("Save Count=" + napravlenie.Count);
            foreach (var n in napravlenie)
            {
                Console.WriteLine("Save Key=" + n.Key + ", Save Value=" + n.Value);
            }
            */
            try
            {

                logic.CreateOrUpdate(new StudentBindingModel
                {
                    Id = id,
                    FIO = textBoxFIO.Text,
                    DatePostuplen=dateControl.SelectedValue,
                    Napravlenies=napravlenie
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCensel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fio))
                id = null;
            else
                id = logic.Read(null).FirstOrDefault(rec => rec.FIO == fio).Id;
            napravlenie = new Dictionary<string, string>();
            LoadData();
            if (id.HasValue)
            {
                try
                {
                    StudentViewModel view = logic.Read(new StudentBindingModel { Id = id })?[0];
                    if (view != null)
                    {
                        textBoxFIO.Text = view.FIO;
                        dateControl.SelectedValue = view.DatePostuplen;
                        napravlenie = view.Napravlenies;
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                napravlenie = new Dictionary<string, string>();
            }

        }
        
        private void LoadData()
        {
            try
            {
                Console.WriteLine("Load");
                /*
                dataGridView.Columns.Clear();
                dataGridView.Columns.Add("Number", "№");
                dataGridView.Columns.Add("Name", "Название специальности");
                dataGridView.Columns[0].Visible = false;
                dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                if (napravlenie != null)
                {
                    dataGridView.Rows.Clear();
                    foreach (var pi in napravlenie)
                    {
                        Console.WriteLine("Key= "+pi.Key+"; Value= " + pi.Value);
                        dataGridView.Rows.Add(new object[] { pi.Key, pi.Value });
                    }
                }
                */
                if (napravlenie.Values.Count == 0)
                {
                    Console.WriteLine("0");
                    var napravlenies = logicN.Read(null).Select(rec => rec.Name).ToList();
                    checkBoxControl.LoadList(napravlenies);
                }
                else
                {
                    Console.WriteLine("1");
                    var napravlenies = logicN.Read(null).Select(rec => rec.Name).ToList();
                    /*
                    int[] mas = new int[napravlenie.Values.Count];
                    int i = 0;                    
                    foreach (var v in napravlenie.Values)
                    {
                        mas[i] = Convert.ToInt32(v);
                    }
                    */
                    checkBoxControl.LoadList(napravlenies);
                    checkBoxControl.SelectedText=napravlenie.Values.ToArray();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
