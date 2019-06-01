using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerApp
{
    class Player
    {
        private int _id;
        private string _name;
        
        private GenderOptions _gender;
        public Player(int _id, string _name, GenderOptions _gender)
        {
            this._id = _id;
            this._name = _name;
            this._gender = _gender;
        }
        public Player(int id, string name) : this(id, name, GenderOptions.male)
        {

        }
        public int Id
        {
            get
            {
                return _id;
            }

        }
        public string Name
        {
            get 
            {
                return _name;
            }

        }
       public GenderOptions Gender
        {
            get
            {
                return _gender;
            }

        }
     //   public int Age
       // {
         //   set
          //  {

            //}
           
        } 

    }
}
