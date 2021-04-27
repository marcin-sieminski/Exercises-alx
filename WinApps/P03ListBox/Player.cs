using System;

namespace P03ListBox
{
    public class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public DateTime BirthDate { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        public Player()
        {
            
        }

        public Player(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetInfo()
        {
            return $"{FirstName} {LastName} ({Country})";
        }
    }
}
