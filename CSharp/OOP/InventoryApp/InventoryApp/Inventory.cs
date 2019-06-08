using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace InventoryApp
{
    class Inventory
    {
        // need to add search 
        // see 32 page solution
        private ArrayList _guitars;

        public Inventory()
        {
            _guitars = new ArrayList();

        }

        public void AddGuitar(string serialNumber, double price, GuitarSpec spec)
        {
            Guitar guitar = new Guitar(serialNumber, price, spec);
            _guitars.Add(guitar);
        }
        public ArrayList search(GuitarSpec searchspec)
        {
            ArrayList MatchingGuitar = new ArrayList();
            foreach(Guitar git in _guitars)
            {
                if(git.Spec.Matches(searchspec))
                {
                    MatchingGuitar.Add(git);
                }
               
                
            }
            return MatchingGuitar;

            
        }

    }
}
