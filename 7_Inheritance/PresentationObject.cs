
namespace LearningInheritance
{
    class PresentationObject
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public void Copy()
        {
            Console.WriteLine("Copying a presentation object");
        }
        public void Duplicate()
        {
            Console.WriteLine("Duplicating a presentation object");
        }

    }
}