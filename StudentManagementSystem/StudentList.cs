using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class StudentList : IEnumerable

    {
        readonly List<Student> Students = new List<Student>();


        public void RegisterStudent(string name, string surname, DateTime dateOfBirth, int rollNumber, char grade)
        {
            Students.Add(name, surname, dateOfBirth, rollNumber, grade);
        }

        public IEnumerator GetEnumerator()
        {
            return Students.GetEnumerator();
        }
    }
}
