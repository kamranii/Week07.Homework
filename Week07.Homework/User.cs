using System;
using System.Globalization;
namespace Week07.Homework
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public string Country { get; set; }
        public User(string name, string surname, byte age, string country)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Country = country;
        }
        public void PrintFullInfo()
        {
            Console.WriteLine($"{this.Name} {this.Surname} {this.Age} {this.Country}");
        }
    }
}

