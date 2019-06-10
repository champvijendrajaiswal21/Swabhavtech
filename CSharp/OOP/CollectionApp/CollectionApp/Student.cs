using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionApp
{
    class Student
    {
        private int _rollno;
        private int _standard;
        private string _name;

        public Student(int rollno, int standard, string name)
        {
            _rollno = rollno;
            _standard = standard;
            _name = name;
        }
        public override bool Equals(object obj)
        {
            Student item = (Student)obj;
            if (item._rollno == this._rollno && item._standard == this._standard)
                return true;
            else
                return false;
        }
        public override int GetHashCode()
        {
            return 1;
        }
    }
}
