using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class NapravlenieStudent
    {
        public int Id { get; set; }
        public int NapravlenieId { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public virtual Napravlenie Napravlenie { get; set; }
    }
}
