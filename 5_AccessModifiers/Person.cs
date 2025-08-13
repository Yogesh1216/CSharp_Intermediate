namespace LearningAccessModifiers
{
    public class Person
    {
        private DateTime _birthdate;
        public void SetBirthdate(DateTime birthdate)
        {
            if (birthdate > DateTime.Now)
            {
                throw new ArgumentException("Birthdate cannot be in the future.");
            }
            _birthdate = birthdate;
        }
        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
}