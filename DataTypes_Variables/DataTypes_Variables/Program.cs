namespace DataTypes_Variables
{
    class Program
    {
        // https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/#types-and-variables
        /*
        Simple types:
            1. Signed integral: sbyte, short, int, long
            2. Unsigned integral: byte, ushort, uint, ulong
            3. Unicode characters: char, which represents a UTF-16 code unit
            4. IEEE binary floating-point: float, double
            5. High-precision decimal floating-point: decimal
            6. Boolean: bool, which represents Boolean values—values that are either true or false
        */
        static void Main(string[] args)
        {
            int x = 7;
            int y = x + 5;
            Console.WriteLine(y);

            Console.WriteLine("What is your name?");
            Console.WriteLine("Type your first name:");
            string myFirstName = Console.ReadLine();

            Console.WriteLine("Type your last name:");
            string myLastName = Console.ReadLine();

            Console.WriteLine($"Hello, {myFirstName} {myLastName}");
        }
    }
}
