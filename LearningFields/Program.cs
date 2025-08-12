namespace LearningFields
{
    /// <summary>
    /// 1. why readonly is used in reallife eg.
    /// 2. we must assign the Orders object list when we declare it (one to many)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var customer1 = new Customer(1);
            customer1.Orders.Add(new Order());
            customer1.Orders.Add(new Order());

            customer1.Promote();

            Console.WriteLine(customer1.Orders.Count);


        }
    }
}