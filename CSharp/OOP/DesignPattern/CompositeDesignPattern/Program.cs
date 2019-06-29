﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee CEO = new Employee("John", "CEO", 30000);

            Employee headSales = new Employee("Robert", "Head Sales", 20000);

            Employee headMarketing = new Employee("Michel", "Head Marketing", 20000);

            Employee clerk1 = new Employee("Laura", "Marketing", 10000);
            Employee clerk2 = new Employee("Bob", "Marketing", 10000);

            Employee salesExecutive1 = new Employee("Richard", "Sales", 10000);
            Employee salesExecutive2 = new Employee("Rob", "Sales", 10000);

            CEO.add(headSales);
            CEO.add(headMarketing);

            headSales.add(salesExecutive1);
            headSales.add(salesExecutive2);

            headMarketing.add(clerk1);
            headMarketing.add(clerk2);

            //print all employees of the organization
            Console.WriteLine( CEO);

            foreach (Employee headEmployee in  CEO.getSubordinates())
            {
                Console.WriteLine( headEmployee);

                foreach (Employee employee in headEmployee.getSubordinates())
                {
                    Console.WriteLine( employee);
                }
            }
        }
    }
}
