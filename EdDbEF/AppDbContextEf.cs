using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdDbEF
{
    public class AppDbContextEf : DbContext
    {
        public DbSet<Assignment> Assignment { get; set; }
        public DbSet<Class> Classe { get; set; }
        public DbSet<ClassGrade> ClassGrade { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Major> Major { get; set; }
        public DbSet<MajorClass> MajorClasse { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<StudentClass> StudentClass { get; set; }

        public AppDbContextEf() { }
        public AppDbContextEf(DbContextOptions<AppDbContextEf> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connstr = "server=localhost\\sqlexpress; " +
            "database=EdDb; " +
            "trusted_connection=true; " +
            "trustServerCertificate=true; ";
            optionsBuilder.UseSqlServer(connstr);
        }
    }
}
