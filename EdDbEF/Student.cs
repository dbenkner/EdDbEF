using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdDbEF
{
    public class Student
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string StateCode { get; set; }
        public int? SAT { get; set; }
        public decimal GPA {get; set;}

        public int? MajorId { get; set; }

        public override string ToString()
        {
            return $"{Id} | {Firstname} | {Lastname} | {StateCode} | {SAT} | {GPA:N2} | {MajorId}";
        }


    }
}
