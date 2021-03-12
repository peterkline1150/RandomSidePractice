using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        
        private double _salary;

        public double GetSalary()
        {
            return _salary;
        }
        public void SetSalary(double salary)
        {
            _salary = salary;
        }
        public string GetFullName()
        {
            string fullName = $"{FirstName} {LastName}";
            return fullName;
        }
    }
}
