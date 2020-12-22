using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Models;

namespace Database
{
    public class StudentDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=LIZA\SQLEXPRESS;Initial Catalog=StudentDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Student> Students { set; get; }
        public virtual DbSet<Napravlenie> Napravlenies { set; get; }
        public virtual DbSet<NapravlenieStudent> NapravlenieStudents { set; get; }
    }
}
