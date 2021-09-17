using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningChallenge_MCW1D
{
    public class User
    {
        public User() { }//blank constructor

        public User(string firstName, string lastName, int id, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            BirthDate = birthDate;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; }
        public DateTime BirthDate { get; set; }

        public void FullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

        public int AgeInYear(DateTime birthdate)
        {
            int age = DateTime.Now.Year - birthdate.Year;
            return age;
        }
    }
}
