using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EngineeringCollegeApp.SalariedEmployee;

namespace EngineeringCollegeApp
{
   public class College
    {
        private string _name;
        private string _location ;
        List<Student> _student;
        List<Professor> _professor; 

        public College (string name , string location )
        {
            _name = name;
            _location = location;

        }

        public string Name
        {
            get
            {
                return _name; 
            }
        }

        public string Location
        {
            get
            {
                return _location;
            }
        }

        public void AddProfessor(Professor professor)
        {
            _professor.Add(professor);

        }
        public void AddStudent(Student student)
        {
            _student.Add(student);
        }
        public List<Professor> GetProfessor()
        {
            return _professor;
        }
        public List<Student> GetStudent()
        {
            return _student;
        }

    }
}
