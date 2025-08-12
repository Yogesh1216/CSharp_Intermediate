namespace LearningFields
{
    public class Customer
    {
        public int Id;
        public string Name;
        readonly public List<Order> Orders = new List<Order>();  // to stop reassignment of the Orders list eg Promote method.

        public Customer(int id)
        {
            this.Id = id;
        }
        public Customer(int id, string name) 
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            //Orders = new List<Order>();
        }



    }
}