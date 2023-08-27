using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdDbEF
{
    public class Assignment
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int ClassId { get; set; }
        public override string ToString()
        {
            return $"{Id} | {Description} | {ClassId}";
        }
    }
}
