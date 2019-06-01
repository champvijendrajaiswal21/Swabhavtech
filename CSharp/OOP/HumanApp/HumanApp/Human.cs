using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanApp
{
    class Human
    {
        private readonly string _name;
        private float _height;
        private float _weight;
        private readonly int _age;
        private string _gender;
        public Human(string name , float height , float weight , int age)
        {
            _name = name;
            _height = height;
            _weight = weight;
            _age = age;
            _gender = "male";


        }
        public Human(string name, float height, float weight):this( name,height,weight,18)
        {
           
            

        }
        public string Name
            {
            get
            {
                return _name;
            }
            }
        public float Height
        {
            get
            {
                return _height;
            }
        }
        public float Weight
        {
            get
            {
                return _weight;
            }
        }
        public int  Age
        {
            get
            {
                return _age;
            }
        }
        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                value = value.ToLower();
                if (value == "female")
                {
                    _gender = value;
                }
               
              
            }
        }
        public void Workout()
        {
            _weight = _weight -(_weight * 0.02f);
        }
        public void Eat()
        {
            _weight = _weight + (_weight * 0.05f);
            _height = _height + (_height * 0.01f);
        }
       

    }
}
