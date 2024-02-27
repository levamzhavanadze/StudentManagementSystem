using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        // public int CurrentAge { get; set; }

        public Person(string name, string surname, DateTime dateOfBirth)
        {
            FirstName = name;
            LastName = surname;
            DateOfBirth = dateOfBirth;
            //      CurrentAge = CalculateCurrentAge(dateOfBirth);
        }


        public int CalculateCurrentAge(DateTime dateOfBirth)
        {
            DateTime currentDate = DateTime.Now;

            if (currentDate < dateOfBirth)
            {
                throw new ArgumentException("Invalid date of birth");
            }

            int years = currentDate.Year - dateOfBirth.Year;

            // Adjust age if the birthday hasn't occurred yet this year
            if (currentDate.Month < dateOfBirth.Month || (currentDate.Month == dateOfBirth.Month && currentDate.Day < dateOfBirth.Day))
            {
                years--;
            }

            return years;
        }


        public override string ToString()
        {
            return $"First Name: {FirstName}; Last Name: {LastName}; Age: {CalculateCurrentAge(DateOfBirth).ToString()}";
        }

    }
}
