using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer("akash", "20-07-2010", 50000);
            Console.WriteLine(developer.ToString());
            Accountant  accountant = new Accountant("dhruv","05-02-2010",20000);
            Console.WriteLine(accountant.ToString());
            Manager manager = new Manager("sanal","31-07-2015",30000);
            Console.WriteLine(manager.ToString());

        }
       /* public static void Display( Employee employee)
        {
            Type t = employee.GetType();
            Console.WriteLine("Name = "+employee.Name);
            Console.WriteLine("date = "+employee.DateOfJoining);
            Console.WriteLine("salary = "+employee.BasicSalary);
           if(t.Name=="Developer")

            {
                Developer developer;
                developer = (Developer)employee;
                Console.WriteLine("Bonus = "+developer.Bonus);
                Console.WriteLine("PA = "+developer.PerformanceAllowance);
                Console.WriteLine("total salary = "+developer.CalculateDeveloperAllowance+developer.BasicSalary);

               
            }
           else if (t.Name == "Accountant")
            {
                Accountant account;
                account = (Accountant)employee;
                Console.WriteLine("perk = "+account.Perk);
                Console.WriteLine("total salary = " + account.CalculateAccountantAllowance+ account.BasicSalary);
            }
            else
            {
                Manager manager;
                manager = (Manager)employee;
                Console.WriteLine(" HRA = "+manager.HouseRentalAllowance);
                Console.WriteLine("TA = "+manager.TravelAllowance);
                Console.WriteLine("DA = "+manager.DearnessAllowance);
                Console.WriteLine("total salary = " + manager.CalculateManagerAllowance + manager.BasicSalary);
            }
                
            
    */
            
            
      //  }
        
    }
}
