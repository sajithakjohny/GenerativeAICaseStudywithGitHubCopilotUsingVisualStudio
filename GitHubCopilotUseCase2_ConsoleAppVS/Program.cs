using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubCopilotUseCase2_ConsoleAppVS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentData studentData = new StudentData();
            List<Student> students = studentData.GetStudents();
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"Age: {student.Age}");
                Console.WriteLine($"Address: {student.Address}");
                Console.WriteLine($"Email: {student.Email}");
                Console.WriteLine($"Phone Number: {student.PhoneNumber}");
                Console.ReadLine();
            }
        }
    }
}
