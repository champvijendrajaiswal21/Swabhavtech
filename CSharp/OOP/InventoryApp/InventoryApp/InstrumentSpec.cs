﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryApp
{
  public  class InstrumentSpec
    {
        private Dictionary<string , object> _properties;

        public InstrumentSpec(Dictionary<string, object> properties)
        {
            if (properties == null)
                _properties = new Dictionary<string, object>();
            else
                _properties = new Dictionary<string, object>(properties);                                                    
        }

        public object GetProperty(string propertyName)
        {
            return _properties[propertyName];
        }

        public Dictionary<string, object> Properties
        {
            get
            {
                return _properties;
            }
        }

        public bool Matches(InstrumentSpec otherspec)
        {
            foreach (KeyValuePair<string, object> property in otherspec._properties)

            {
                if (!(this._properties.Contains(property)))
                    return false;
            }
            return true;

        }
    }
}
