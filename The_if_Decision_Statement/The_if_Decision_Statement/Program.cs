namespace The_if_Decision_Statement
{
    class Program
    {
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements#the-if-statement
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's Big giveaway");
            Console.WriteLine("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();
            string message = "";

            if (userValue == "1")
            {
                message = "You won a new car!";  
            } 
            else if (userValue == "2")
            {
                message = "You won a new boat!";    
            } 
            else if (userValue == "3")
            {
                message = "You won a new cat!";                
            }
            else
            {
                message = "We didn't understand";                
            }
            Console.WriteLine(message);

            Console.WriteLine("Ok.. choose your favorite temp: ");
            string result = Console.ReadLine();
            int favTemp = int.Parse(result);

            DisplayWeatherReport(favTemp);

        }

        static void DisplayWeatherReport(int tempInCelsius)
        {
            if (tempInCelsius < 20)
            {
                Console.WriteLine("Cold.");
            }
            else if (tempInCelsius > 20 && tempInCelsius < 35)
            {
                Console.WriteLine("Perfect!");
            }
            else
            {
                Console.WriteLine("Are you ok?");
            }
        }
    }
}