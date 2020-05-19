using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne
{
    public class Person
    {

        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string FirstName {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value.Length < 2)
                    throw new ArgumentException("FistName connot contain less than 3 letters");
                this.firstName = value;
            } 
        }
        //public string FirstName { get { return this.firstName; } }
        public string LastName { get { return this.lastName; } }
        public int Age { get { return this.age; } }

        

        public override string ToString()
        {
            return  $"{FirstName} {LastName} is {Age} years old."; 
            
        }
    }
}
