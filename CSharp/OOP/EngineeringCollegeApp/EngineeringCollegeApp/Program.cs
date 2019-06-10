using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EngineeringCollegeApp.SalariedEmployee;
namespace EngineeringCollegeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor professor = new Professor(01,new DateTime(1980,05,20),"bandra",100000d,2000);
            Student student = new Student(10001,new DateTime(1996,07,20),"prabhadevi",Branch.COMPUTER_ENGINEERING);
            College college = new College("Vidyalankar","Wadala");
            Console.WriteLine("Name = "+college.Name);
            Console.WriteLine(" location = "+college.Location);
            college.AddProfessor(professor);
            college.AddStudent(student);
            Display(professor);
            Display(student);


        }
        public static void  Display( Person person)
        {
            Console.WriteLine(" id = "+person.Id);
            Console.WriteLine("date of birth = "+person.DateOfBirth);
            Console.WriteLine(" address = "+person.Address);
            if (person is Professor)
            {
               Professor professor = (Professor)person;
                Console.WriteLine("total salary ="+professor.CalculateSalary());
                Console.WriteLine("Bonus ="+professor.Bonus);
                Console.WriteLine("salary = "+professor.Salary);
            }
            if(person is Student)
            {
                Student student = (Student)person;
                Console.WriteLine("branch ="+student.BRANCH);
            }
        }

    }
}
