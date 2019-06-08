using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace InventoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            InitializeInventor(inventory);
            GuitarSpec whatErinLikes = new GuitarSpec(Builder.FENDER,"Stratocastor",Type.ELECTRIC,Wood.ALDER,Wood.ALDER);
            ArrayList matchingGuitar = inventory.search(whatErinLikes);
            EnumToString es = new EnumToString();
            if(matchingGuitar.Count>=0)
            {
                Console.WriteLine("enter in if");
                foreach(Guitar g in matchingGuitar)
                {
                   
                    GuitarSpec specs = g.Spec;
                    Console.WriteLine(  "we have a " +es.BuilderToString(specs.Builder)+" "+specs.Model+" "+ es.TypeToString(specs.Type)+"guitar:\n"+es.WoodToString(specs.Backwood)+"back and sides,\n  "+es.WoodToString(specs.Topwood)+"top.\n you can have it for only $"+g.Price+"!\n ----");

                }
            }
            else
            {
                Console.WriteLine("sorry , Erin , we have nothing for you");
            }
               
                 
        }
        private static void InitializeInventor(Inventory inventory)
        {
            inventory.AddGuitar("V95693", 1499.95, new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER));
            inventory.AddGuitar("V9512", 1549.95, new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER));

        }
    }
}
