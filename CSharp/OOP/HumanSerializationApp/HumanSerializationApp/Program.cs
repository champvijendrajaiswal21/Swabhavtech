using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using HumanApp;

namespace HumanSerializationApp
{
    class Program
    {
        public static string path="C:/SwabhavRespo/CSharp/human.txt";
        static void Main(string[] args)
        {
            Human human1 = new Human("akash",5.0f,50.0f,22);
            Human human2 = new Human("Dhruv",6.0f,55.0f,21);
            ArrayList human = new ArrayList();
            human.Add(human1);
            human.Add(human2);
            Console.WriteLine("serialization process on");
            Serialization(human);
            Info(human1);
            Info(human2);
            human1.Eat();
            human2.Workout();
            Info(human1);
            Info(human2);
            Console.WriteLine("after deserialzation process");
            ArrayList humanlist = Deserialized();
            foreach(Human human_list in humanlist)
            {
                Info(human_list);
            }

        }
        public static void Info(Human human)
        {
            Console.WriteLine("name = "+human.Name+"height = "+human.Height+"weight = "+human.Weight+"age ="+human.Age);
        }

        public static void Serialization(ArrayList list)
        {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, list);
            fs.Close();
        
        }
        public static ArrayList Deserialized()
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            return (ArrayList) formatter.Deserialize(fs);
        }
    }
}
