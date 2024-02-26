using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class Student : Person
    {
        public int RollNumber {  get; set; }
        public char Grade { get; set; }
        public Student(string name, string surname, DateTime dateOfBirth, int rollNumber, char grade) : base(name, surname, dateOfBirth)
        {
            RollNumber = rollNumber;
            Grade = grade;
        }


        public override string ToString()
        {
            return base.ToString() +"; "+ $"Roll Number: {RollNumber}; Grade {Grade}";
        }

    }
}
