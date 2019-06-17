using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryApp
{
    class EnumToString
    {
        public string WoodToString(Wood w)
        {
            switch (w)
            {
                case Wood.ADIRONDACK:
                    return "Adirondack";
                case Wood.ALDER:
                    return "Alder";
                case Wood.BRAZILIAN_ROSEWOOD:
                    return "Brazilian Rosewood";
                case Wood.CEDAR:
                    return "Cedar";
                case Wood.COCOBOLO:
                    return "Cocobolo";
                case Wood.INDIAN_ROSEWOOD:
                    return "Indian Rosewood";
                case Wood.MAHOGANY:
                    return "Mahogany";
                case Wood.MAPLE:
                    return "Maple";
                case Wood.SITKA:
                    return "Sitka";

                default:
                    return "wrong choice";


            }
        }

        public string TypeToString(Type w)
        {
            switch (w)
            {
                case Type.ACOUSTIC:
                    return "Acoustic";
                case Type.ELECTRIC:
                    return "Electric";

                default:
                    return "wrong choice";


            }
        }
        public string BuilderToString(Builder w)
        {
            switch (w)
            {
                case Builder.ANY:
                    return "Any";

                case Builder.COLLINGS:
                    return "Collings";
                case Builder.FENDER:
                    return "Fender";
                case Builder.GIBSON:
                    return "Gibson";
                case Builder.MARTIN:
                    return "Martin";
                case Builder.OLSON:
                    return "Olson";
                case Builder.PRS:
                    return "Prs";
                case Builder.RYAN:
                    return "Ryan";
               default:
                    return "wrong choice";


            }
        }
             public string InstrumentTypeToString(InstrumentType i)
        { 
            switch (i)
            {

                case InstrumentType.BANJO:
                    return "Banjo";

                case InstrumentType.BASS:
                    return "Bass";

                case InstrumentType.DOBRA:
                    return "Dobra";
                case InstrumentType.FIDDLE:
                    return "Fiddle";
                case InstrumentType.GUITAR:
                    return "guitar";
                case InstrumentType.MANDOLIN:
                    return "Mandolin";

                default:
                    return "wrong choice";


            }
        }

        }
}
