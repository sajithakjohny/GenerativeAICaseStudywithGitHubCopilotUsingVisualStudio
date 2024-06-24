using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubCopilotUseCase2_ConsoleAppVS
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
    //Create a query who is 21 years old
    public class StudentQuery
    {
        public List<Student> GetStudentsByAge(List<Student> students, int age)
        {
            return students.Where(s => s.Age == age).ToList();
        }
    }
   

    //Data
    public class StudentData
    {
        public List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student {
                    Name = "John",
                    Age = 20,
                    Address = "123 Main St",
                    Email = "JohnStudent1@gmail.com",
                    PhoneNumber = "123-456-7890"                   
                    },  
                 //Generate new student data    
                 new Student {
                    Name = "Jane",
                    Age = 21,
                    Address = "456 Elm St",
                    Email = "JaneStudent2@gmail.com",
                    PhoneNumber = "123-456-7891"
                },
                    new Student {
                    Name = "Willam",
                    Age = 21,
                    Address = "789 Elm St",
                    Email = "WillamStudent3@gmail.com",
                    PhoneNumber = "123-456-7892"
                },
                    new Student {
                    Name = "Sofy",
                    Age = 24,
                    Address = "789 Elm St",
                    Email = "SofyStudent4@gmail.com",
                    PhoneNumber = "123-456-7893"
                }

            };
        }
    }
}
