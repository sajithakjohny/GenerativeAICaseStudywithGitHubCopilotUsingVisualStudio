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
                    Email = "student@gmail.com",
                    PhoneNumber = "123-456-7890"
                }
            };
    }
    }
}
