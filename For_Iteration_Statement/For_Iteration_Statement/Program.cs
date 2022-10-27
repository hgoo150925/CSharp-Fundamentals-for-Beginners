namespace For_Iteration_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-for-statement
            // La declaración "for" ejecuta una sentencia o un bloque de sentencias mientras una expresión booleana específica se evalúa como true. 
            
            for (int i = 0; i <= 5; i++)
            {
                // Console.Write(i);
                // Output: 012345
                if (i == 3)
                {
                    Console.WriteLine("Found three");
                    break;
                }

            }

            for (int i = 0; i <   5; i--)
            {
                Console.WriteLine(i);
            }


        }
    }
}
