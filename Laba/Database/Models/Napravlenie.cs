using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class Napravlenie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey("NapravlenieId")]
        public virtual List<NapravlenieStudent> Students { get; set; }
    }
}
