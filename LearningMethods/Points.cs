namespace LearningMethods
{
    class Points
    {
        public int X;
        public int Y;

        public Points(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Move(Points newLocation)
        {
            if(newLocation == null)
                throw new ArgumentNullException("New location cannot be null.");
            Move(newLocation.X, newLocation.Y);
        }
    }
}