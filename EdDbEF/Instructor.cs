using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdDbEF
{
    public class Instructor
    {
        public int Id { get; set; } 
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int YearsExperience { get; set; }
        public Boolean IsTenured { get; set; }
    }
}
