using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class Students
    {
        public List<string> students;
        
        public List<string> LoadData()
        {
            students = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                string text = "Студент" + (i + 1);
                students.Add(text);
            }
            return students;
        }
    }
}
