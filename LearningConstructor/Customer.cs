namespace LearningConstructor
{
    class Customer
    {
        // whenever a class has list of objects 
        public int Id;
        public string Name;
        public List<Orders> Orders;

        public Customer()
        {
            Orders = new List<Orders>();
        }

        public Customer(int id)
            :this()   // this() calls the default constructor before executing this constructor
        {
            Id = id;
        }
        public Customer(int id, string name)
            :this(id)  // this(id) calls the constructor with one parameter before executing this constructor
        {
            //Id = id;
            Name = name;
        }


    }
}