namespace Properties
{
    /// <summary>
    /// 1. Properties: Encapsulates a getter and setter for a field.
    /// </summary>
    class Program
    {
        public static void Main(string[] args)
        {
            var person1 = new Person(new DateTime(1990, 1, 1));
            // person1.Birthdate = new DateTime(2000, 1, 1); // This will give an error because Birthdate has a private setter.
            Console.WriteLine($"Person 1 Age: {person1.Age}");
        }
    }
}