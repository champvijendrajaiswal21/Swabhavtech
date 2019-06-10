using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EngineeringCollegeApp
{
    public class Person
    {
        private int _id;
        private DateTime _dateofbirth;
        private string _address;

        public Person (int id , DateTime dateofbirth , string address)
        {
            _id = id;
            _dateofbirth = dateofbirth;
            _address = address;
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }
        public string Address
        {
            get
            {
                return _address;
            }
        }
        public DateTime DateOfBirth
        {
            get
            {
                return _dateofbirth;
            }
        }
    }
}
