using System.Xml.Linq;

namespace Understanding_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/#array-overview
            // https://www.geeksforgeeks.org/array-data-structure/
            // https://www.geeksforgeeks.org/introduction-to-arrays/

            /*
            La estructura de datos más básica pero importante es la matriz. 
            Es una estructura de datos lineal. 
            Una matriz es una colección de tipos de datos homogéneos donde los elementos se asignan a la memoria contigua. 
            Debido a la asignación contigua de memoria, se puede acceder a cualquier elemento de una matriz en tiempo constante. 
            Cada elemento de la matriz tiene un número de índice correspondiente
            */

            string[] countries = { "AR", "PY", "UK", "DK" };
            Console.WriteLine(countries.Length);

            for(int i = 0; i < countries.Length; i++)
			{
                if (countries[i] == "UK")
                {
                    Console.WriteLine("I live in United Kingdom");
                    break;
                }

            }
            foreach (string country in countries)
            {
                Console.WriteLine(country);
            }

            string zig = "Program for array rotation";
            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);
            foreach (var item in charArray)
            {
                Console.Write(item);
            }

            int[] nums = { 1, 2, 3 };
            Console.WriteLine(sumArray(nums));           
            
        }

        static int sumArray(int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            return sum;
        }
    }
}
