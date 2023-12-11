using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectDb.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string SecondName { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string JobTitle { get; set; }
        public string Characteristics { get; set; }
        public int WorkExperience { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int AmountOfKids { get; set; }
        public decimal Salary { get; set; }
    }
}
