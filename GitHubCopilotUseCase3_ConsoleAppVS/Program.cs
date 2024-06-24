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
            //excute the query
            StudentData studentData = new StudentData();
            List<Student> students = studentData.GetStudents();
            StudentQuery studentQuery = new StudentQuery();
            List<Student> studentsByAge = studentQuery.GetStudentsByAge(students, 21);
            foreach (var student in studentsByAge)
            {
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"Age: {student.Age}");
                Console.WriteLine($"Address: {student.Address}");
                Console.WriteLine($"Email: {student.Email}");
                Console.WriteLine($"Phone Number: {student.PhoneNumber}");
                Console.ReadLine();
            }
            Console.WriteLine(
                "Hello! This is a simple console application that demonstrates the use of GitHub Copilot in Visual Studio.");
            Console.WriteLine("The application displays a list of students who are 21 years old.");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.WriteLine(
                "The application uses a Student class to define the properties of a student, such as Name, Age, Address, Email, and PhoneNumber.");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.WriteLine(
                "The application also uses a StudentQuery class to create a query that filters students by age.");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.WriteLine(
                "The application uses a StudentData class to provide a list of students with sample data.");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.WriteLine(
                "The application then executes the query to filter students who are 21 years old and displays the results.");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.WriteLine("Here are the students who are 21 years old:");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.WriteLine("Name: Jane\nAge: 21\nAddress: 456 Elm St\nEmail:");
            Console.WriteLine("Name: Willam\nAge: 21\nAddress: 789 Elm St\nEmail:"); 
            Console.ReadLine();
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
            Console.WriteLine(
                "Thank you for using this application! I hope you found it helpful in understanding how GitHub Copilot works in Visual Studio.");
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();

            //StudentData studentData = new StudentData();
            //List<Student> students = studentData.GetStudents();
            //foreach (var student in students)
            //{
            //    Console.WriteLine($"Name: {student.Name}");
            //    Console.WriteLine($"Age: {student.Age}");
            //    Console.WriteLine($"Address: {student.Address}");
            //    Console.WriteLine($"Email: {student.Email}");
            //    Console.WriteLine($"Phone Number: {student.PhoneNumber}");
            //    Console.ReadLine();
            //}
        }
    }
}
