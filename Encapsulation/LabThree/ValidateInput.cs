using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabThree
{
    class ValidateInput
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public ValidateInput(string firstName, string lastName, int age, decimal salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }
        public string FirstName
        {
            get
            {
                if (firstName.Length < 2)
                {
                    throw new ArgumentException("Fist name cannot contain less than 3 letters");
                }
                else
                    return firstName;
            }
            private set
            {                    
               this.firstName = value;
            }
        }

        public string LastName {
            get
            {
                if (lastName.Length < 2)
                {
                    throw new ArgumentException("Last name cannot contain less than 3 letters");
                }
                else
                    return lastName; 
            }
            set
            {

                this.lastName = value;
            }

        }
        public int Age {
            get
            {
                if (age < 0)
                    throw new ArgumentException("Age cannot be zero or negative");
                else
                    return this.age;
            }
            set
            {

                this.age = value;
            }
        }
        public decimal Salary {
            get 
            {
                if (salary < 460)
                    throw new ArgumentException("Salary cannot be less than 460 dollars");
                else
                    return salary;
            }
            private set
            {

                salary = value;
            }
        }

        public override string ToString()
        {
            try
            {

                return $"{FirstName} {LastName} is {Age} and gets {Salary} dollars.";
            }
            catch(ArgumentException e)
            {
                return $"{e.Message}";
            }          
        }
    }
}
