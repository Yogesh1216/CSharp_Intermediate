namespace LearningMethods
{
    ///summary <summary>
    /// 1. use of params
    /// 2. use of out parameters
    /// 3. use of method overloading
    /// 4. Code refinement in Points class to handle null checks and constructor initialization.
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            var result = int.TryParse("123", out number);
            if (result)
            {
                Console.WriteLine($"Parsed number: {number}");
            }
            else
            {
                Console.WriteLine("Failed to parse the number.");
            }

        }

        static void UseParams()
        {
            // CALCULATOR EXAMPLE - use of params
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(1, 2, 1, 1));
        }

        static void UsePoints()
        {
            try
            {
                var Point1 = new Points(10, 20);
                Point1.Move(new Points(100, 200));
                Console.WriteLine($"Point is at {Point1.X} , {Point1.Y}");
                Point1.Move(50, 60);
                Console.WriteLine($"Point is at {Point1.X} , {Point1.Y}");
            }
            catch (Exception)
            {

                Console.WriteLine($"An Unexpected error Occured");
            }
        }
    }
}