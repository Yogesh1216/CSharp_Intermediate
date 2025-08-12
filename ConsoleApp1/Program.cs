using System;

namespace Classes
{
    /// <summary>
    /// 1. creating a object of class within the class itself using static method
    /// 2. object initializers: syntax to quickly initialize an object without the need to call one of its constructors
    /// </summary>
    public class Person
    {
        public string Name;

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {Name}.");
        }

        public static Person Parse(string input)
        {
            Person person = new Person();
            person.Name = input;
            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Parse("John Doe");
            person.Introduce();

            //object initilizers: syntax to quickly initilize an object without the need to call one of its constructors,
            var person2 = new Person 
                            { 
                                Name = "Jane Doe" 
                            };
        }
    }
}