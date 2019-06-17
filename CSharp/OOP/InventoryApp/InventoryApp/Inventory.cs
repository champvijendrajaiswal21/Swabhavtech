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
        private List<Instrument> instruments;

        public Inventory()
        {
            instruments = new List<Instrument>();
        }


        public void AddInstrument(string serialNumber, double price, InstrumentSpec spec)                                            //Builder builder, string model, Type type, Wood backwood, Wood topwood)
        {
            Instrument instrument = new Instrument(serialNumber, price, spec);

            instruments.Add(instrument);
        }
        public List<Instrument> Search(InstrumentSpec searchspec)
        {
            List<Instrument> Matching = new List<Instrument>();
           foreach(Instrument instrument in instruments)
            {
               if( instrument.Spec.Matches(searchspec))
                {
                    Matching.Add(instrument);
                }

            }
            return Matching;
        }
        public Instrument Get(string serialnumber)
        {
            foreach(Instrument instrument in instruments)
            {
                return instrument;
            }
            return null;
        }

    }

}

