
using System;

namespace Coding.Exercise
{
    //Fix the code
    public class Person
    {
        public string Name { get; set; }
        // TODO: Declare a constructor that takes a name and prints a message
        
        public Person(string name){
            Name = name;
            System.Console.WriteLine($"Person Constructor: {name} ");
            
        }
        
    }

    public class Employee : Person
    {
        // TODO: Declare a constructor that takes a name and an ID, and calls the base class constructor
        public string VollName { get; private set; }    
        public int ID { get; private set; }

        public Employee(string name , string vollname, int id): base (name)
        {
            VollName = vollname;
            ID = id;    
        }
    }

    public class Exercise
    {
        public void PrintMessages()
        {
            // TODO: Create an instance of Employee and print the messages
            Employee employee = new Employee("Maria","Vecerra" , 3);
            
           
        }

         static void Main(string[] args)
            {
           
                
            }
    }

   
}

