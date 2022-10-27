namespace Simple_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://learn.microsoft.com/es-es/dotnet/csharp/methods
            // https://www.geeksforgeeks.org/c-sharp-methods/

            // Hello World
            HelloWorld();

            // Sum array
            int[] nums = { 1, 5, 8, 25 };
            Console.WriteLine(SumArray(nums));

            // Reverse string
            string rs = ReverseString("Olivia Lund");
            Console.WriteLine(rs);

            // https://www.geeksforgeeks.org/c-sharp-method-overloading/
            // La sobrecarga de métodos es la forma común de implementar polimorfismos.
            // Es la capacidad de redefinir una función en más de una forma. 
            // Un usuario puede implementar la sobrecarga de funciones definiendo dos o más funciones en una clase que comparten el mismo nombre
            // C# | Sobrecarga de métodos

            int res;
            res = Add(1, 3);
            Console.WriteLine(res);

            res = Add(2, 4, 5);
            Console.WriteLine(res);

            Countries("AR", "PY");
            Countries("UK", "DK", "US");

        }

        private static void HelloWorld()
        {
            Console.WriteLine("Hello, World!");
        }

        private static int SumArray(int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            return sum;
        }

        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);

            return String.Concat(messageArray);
                    
        }

        // C# | Sobrecarga de métodos
        private static int Add(int a, int b)
        {
            return a + b;
        }

        private static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        private static void Countries(string a, string b)
        {
            Console.WriteLine($"{a} - {b}");
        }

        private static void Countries(string a, string b, string c)
        {
            Console.WriteLine($"{a} - {b} - {c}");
        }
    }
}