namespace LearningInheritance
{
    /// <summary>
    /// 1 . Inheritance: Allows a class to inherit members from another class.
    /// 2.  All Classes are inherited from object class.
    /// 3.  use inheritance when there is a "is a" relationship between the classes.
    /// </summary>
    partial class Program
    {
        public static void Main(string[] args)
        {
            var text1 = new Text();
            text1.Width = 100;
            text1.Copy();
        }
    }
}