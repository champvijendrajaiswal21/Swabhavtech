using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EngineeringCollegeApp
{
   public class Student: Person
    {
        public Branch _branch;

        public Student(int id,DateTime dateofbirth, string address, Branch branch):base(id,dateofbirth,address)
        {
            _branch = branch;
        }

        
            
            
             


        public Branch BRANCH
        {
            get
            {
                return _branch;
            }
        }
    }
}
