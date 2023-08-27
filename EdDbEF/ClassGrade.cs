using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdDbEF
{
    public class ClassGrade
    {
        [Key]
        public string Grade { get; set; }
        public decimal GPA { get; set; }    

    }
}
