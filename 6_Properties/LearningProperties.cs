namespace Properties
{
    class Person
    {
        /*
        private DateTime _birthdate;
        public DateTime Birthdate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }
        */

        // if there is no logic we can also write it as   
        //  internally it creates a private field     | // requirement - set the birthdate only once , we cannot modify it. so create it private set.

        public string Name { get; set; }
        public DateTime Birthdate { get; private set; }  // it means its readonly if its private se we cant assign the value after constructor.
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public int Age
        {
            get
            {
                var timespan = DateTime.Today - Birthdate;
                var years = timespan.Days / 365;
                return years;
            }
            // age should be calculated on the basis of birthdate so no need to set the age.
        }

        
    }
}