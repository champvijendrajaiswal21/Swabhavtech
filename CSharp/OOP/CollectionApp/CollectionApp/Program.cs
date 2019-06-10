using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CollectionApp
{
    class Program 
    {
        static void Main(string[] args)
        {
            try
            {
                //   Case1();




                //  Case2();
                // NewMethod();
                // Case4();
                Dictionary<Student, Student> studentdetails = new Dictionary<Student, Student>();
                Student akash = new Student(1, 10, "Akash");
                Student sanal = new Student(2, 10, "Sanal");
                Student dipesh = new Student(3, 10, "Dipesh");
                studentdetails.Add(akash, akash);
                studentdetails.Add(sanal, sanal);
                studentdetails.Add(dipesh, dipesh);
                Console.WriteLine("enter");
                if (studentdetails.ContainsKey(dipesh))
                    Console.WriteLine("contains");

                Student dipesh2 = new Student(3, 10, "Dipesh");
                if (studentdetails.ContainsKey(dipesh2))
                    Console.WriteLine("contains");
                studentdetails.Add(dipesh2, dipesh2);
                Console.WriteLine(studentdetails.Count);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void Case4()
        {
            HashSet<Student> student = new HashSet<Student>();
            student.Add(new Student(1, 10, "akash"));
            student.Add(new Student(10, 1, "dhruv"));
            Console.WriteLine(student.Count);
        }

        private static void NewMethod()
        {
            HashSet<LineItem> cart = new HashSet<LineItem>();

            cart.Add(new LineItem("Biscuit", 10, 10));
            cart.Add(new LineItem("Biscuit", 10, 10));
            cart.Add(new LineItem("mango", 10, 10));

            Console.WriteLine(cart.Count);
  
    }

        private static void Case2()
        {
            List<LineItem> cart = new List<LineItem>();
            cart.Add(new LineItem("Biscuit", 10, 10));
            cart.Add(new LineItem("applejuice", 2, 20));
            cart.Add(new LineItem("football ", 1, 200));
            cart.Add(new LineItem("tennisball", 5, 50));
            double total = 0;
            foreach (LineItem item in cart)
            {
                Console.WriteLine("Name = " + item.ProductName + " " + item.CalculateTotal());
                total = total + item.CalculateTotal();
            }
            Console.WriteLine("total = " + total);
        }

        private static void Case1()
        {
            ArrayList cart = new ArrayList();
            cart.Add(new LineItem("Biscuit", 10, 10));
            cart.Add(new LineItem("applejuice", 2, 20));
            cart.Add(new LineItem("football ", 1, 200));
            cart.Add(new LineItem("tennisball", 5, 50));
            cart.Add("akash");
            cart.Add(23);
            foreach (LineItem item in cart)
            {
                Console.WriteLine(item.CalculateTotal());
            }
        }
    }
}
