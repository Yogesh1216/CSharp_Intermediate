namespace LearningAccessModifiers
{
    /// <summary>
    /// 1. Access Modifiers: public, private, protected, internal
    /// 2. Encapsulation: not accessing the fields directly, using methods to set and get values
    /// </summary>

    class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1990, 1, 1));
            Console.WriteLine(person.GetBirthdate());

        }
    }
}