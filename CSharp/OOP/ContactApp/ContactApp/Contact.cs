using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ContactApp
{
    [Serializable]
    public class Contact
    {
        private String _name;
        private String _email;
        private int _phoneno;

        public Contact(string name, string email, int phoneno)
        {
            _name = name;
            _email = email;
            _phoneno = phoneno;
        }

        public String Name
        {
            get
            {
                return _name;
            }

        }


        public String Email
        {
            get
            {
                return _email;
            }
        }

        public int Phoneno
        {
            get
            {
                return _phoneno;
            }
        }
    }
}
