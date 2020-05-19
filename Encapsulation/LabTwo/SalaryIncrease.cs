using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabOne;

namespace LabTwo
{
    class SalaryIncrease
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public SalaryIncrease(string firstName, string lastName, int age, decimal salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public string FirstName { get { return this.firstName; } }
        public string LastName { get { return this.lastName; } }
        public int Age { get { return this.age; } }
        public decimal Salary { get { return this.salary; } }

        public void IncreasedSalary(decimal percentage)
        {
            if (this.Age > 30)
                this.salary += this.salary * percentage / 100;
            else
                this.salary += this.salary * percentage / 200;

        }



        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} receives {this.salary} dollars.";

        }
    }
}
