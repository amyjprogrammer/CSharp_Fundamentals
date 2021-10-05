using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Classes_Setters
{
    //goals
    //Username must contain between 7-20 characters
    //User must be at least 16
    class Quacker
    {
        //backing field
        private string _userName;
        //=> lamda or fat arrow- only work for single lines of code
        public string UserName 
        { 
            //Get method
            get => _userName; 
            //set Method
            set
            {
                if (value.Length >= 7 && value.Length <= 20)
                    //This is a single line body for if
                    _userName = value;
                else
                    throw new FormatException("Username must be between 7 and 20 characters");
            } 
        }
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 16)
                    throw new ArgumentException("Age must be at least 16");
                _age = value;//this is the else statement 
            }
        }

    }
}
