using System;
 
namespace Coding.Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person("John", 9);
            person.Greet(); // Output: "Hello, my name is John and I am 30 years old."
        }
    }
 
    public class Person
    {
        private string _name;
        private int _age;
 
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
 
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
            }
        }
 
        public Person(string name, int age)
        {
            _name = name;
            Age = age; // Use the property to ensure the value is valid
        }
 
        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {_name} and I am {_age} years old.");
        }
    }
}