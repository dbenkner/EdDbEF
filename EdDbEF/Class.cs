using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace EdDbEF
{
    public class Class
    {
        public int Id { get; set; } 
        public string Code { get; set; }
        public string Subject { get; set; }
        public int Section { get; set; }
        public int? InstructorId { get; set; }

    }
}
