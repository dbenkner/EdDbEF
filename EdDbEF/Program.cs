using EdDbEF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.VisualBasic;
using System.Linq;
using System.Resources;

var _context = new AppDbContextEf();

Main()
void Main()
{
    
}

foreach (var stu in _context.Student.ToList())
{
    Console.WriteLine(stu.ToString());  
}



var avgGPA = _context.Student.Select(stu => stu.GPA).ToList().Average();
var avgSAT = Convert.ToDecimal(_context.Student.Select(stu => stu.SAT).ToList().Average());


Console.WriteLine(Math.Round(avgGPA, 2));
Console.WriteLine(Math.Round(avgSAT, 2));

var studentsAndMajors = from s in _context.Student
                        join m in _context.Major
                        on s.MajorId equals m.Id
                        select new
                        {
                            s.Firstname,
                            s.Lastname,
                            s.GPA,
                            s.SAT,
                            Major = m.Description,
                            s.MajorId
                        };

foreach(var student in studentsAndMajors)
{
    Console.WriteLine($"Student: {student.Firstname} | {student.Lastname} | {student.GPA} | {student.SAT} | {student.Major}");
}

avgGPA = studentsAndMajors.Where(stu => stu.Major == "General Business").Select(stu => stu.GPA).ToList().Average();
Console.WriteLine($"{avgGPA}");




Console.WriteLine($"The total number of students is {_context.Student.ToList().Count()}");

var updateStudent = _context.Student.Find(62);

Console.WriteLine(updateStudent.ToString());

updateStudent.SAT = 955;
_context.Student.Remove(_context.Student.Find(64));
_context.SaveChanges();

/*
Console.WriteLine("Look up major Id");

string majorSearch = Convert.ToString(Console.ReadLine());

int majorId = _context.Major.Where(m => m.Code == majorSearch).Select(m => m.Id).SingleOrDefault();
if(majorId == 0)
{
    Console.WriteLine("No Major Found!");
    return;
}
Console.WriteLine($"{majorSearch} the Id is {majorId}");
Console.WriteLine("Enter in New Student INfo");
Console.WriteLine("Student First Name");
var studentFirstName = Convert.ToString(Console.ReadLine());
Console.WriteLine("Enter Student Last Name");
var studentLastName = Convert.ToString(Console.ReadLine());
Console.WriteLine("Enter 2 digit State Code");
var studentStateCode = Convert.ToString(Console.ReadLine());
Console.WriteLine("Enter Student GPA");
var gpa = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Enter Student SAT Score");
int scoresat = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter student Major ID");
var mId = Convert.ToInt32(Console.ReadLine());

int i = 1;
var newStudent = new Student { Firstname = studentFirstName, Lastname = studentLastName, GPA = gpa, Id = 0, MajorId = mId, SAT = scoresat, StateCode = studentStateCode };
Console.WriteLine($"The new student is {newStudent.ToString()}");
Console.WriteLine("Adding new student!");
*/

