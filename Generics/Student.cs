 using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Student
    {

        public string Name { get; set; }
        public string Discipline { get; set; }

        public Student(string name,string descipline)
        {
            Name = name;
            Discipline = descipline;
        }
        public override string ToString()
        {
            return string.Format("Name : {0} \n Discipline : {1}",Name,Discipline);
        }
    }
}
