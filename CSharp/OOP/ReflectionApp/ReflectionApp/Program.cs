using System;
using PlayerApp;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace ReflectionApp
{
    class Program
    {


        static void Main(string[] args)
        {

            Type t = typeof(Player);
            Console.WriteLine("type name:" + t.Name);
            Console.WriteLine("full name: " + t.FullName);
            Console.WriteLine("namespace: " + t.Namespace);
            MemberInfo[] member = t.GetMembers();
            foreach (MemberInfo NextMember in member)
            {
                Console.WriteLine(NextMember.DeclaringType + " " + NextMember.MemberType
                    + "  " + NextMember.Name);
            }
        }
    }
}
