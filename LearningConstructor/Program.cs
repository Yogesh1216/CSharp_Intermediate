namespace LearningConstructor
{
    /// <summary>
    /// 1. constructor chaining is used to call another constructor from the same class
    /// 2. whenever we declare a object of a class , we must initialize the list of objects in the constructor
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var Customer1 = new Customer();
            Console.WriteLine($"Customer ID: {Customer1.Id}, Name: {Customer1.Name}");

            var Orders = new Orders();
            Customer1.Orders.Add(Orders);
        }
    }
}