namespace While_Iteration_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i < 5)
            {
                Console.WriteLine("while");
                i++;

                if (i >5)
                {
                    break;
                }
            }

            GuessingGame();

        }

        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing game!");

            Random random = new Random();
            int randomNumber = random.Next(0, 50);

            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess the number between 0 and 50");
                string result = Console.ReadLine();
                int res = int.Parse(result);
                guesses++;

                if (res == randomNumber)
                {
                    incorrect = false;                    
                } 
                else if (res > randomNumber )
                {
                    incorrect = true;
                    Console.WriteLine("choose a smaller number");

                }                
                else
                {
                    incorrect = true;
                    Console.WriteLine("choose a higher number");
                }
                


            } while (incorrect);
            Console.WriteLine("Correct! It took {0} guesses", guesses);
            Console.ReadLine();
        }
    }
}
