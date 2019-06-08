﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InterfaceApp.Crud;
using InterfaceApp.Vehicle;

namespace InterfaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
        }
        public static void CaseStudy1()
        {
            DoDbOperation(new CustomerDb());
            DoDbOperation(new DepartmentDb());
            DoDbOperation(new InvoiceDb());

        }
        public static void CaseStudy2()
        {
            IMovable[] movable = new IMovable[3];
            movable[0] = new Car();
            movable[1] = new Bike();
            movable[2] = new Truck();
            StartRace(movable);
        }
        public static void StartRace(IMovable[] movable)
        {
            Console.WriteLine("inside start race operation");
            for(int i =0; i<3;i++)
            {
                movable[i].Move();
            }
        }
        public static void DoDbOperation(ICrudable x)
        {
            x.CreateDb();
            x.ReadDb();
            x.UpdateDb();
            x.DeleteDb();
        }
    }
}
