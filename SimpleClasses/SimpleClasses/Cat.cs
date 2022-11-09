
namespace SimpleClasses
{
    public class Cat
    {
        public string Name { get; }

        public Cat(string name)
        {
            Name = name;
        }

        public void Saludar()
        {
            Console.WriteLine($"Hello {Name}");
        }

    }
}
