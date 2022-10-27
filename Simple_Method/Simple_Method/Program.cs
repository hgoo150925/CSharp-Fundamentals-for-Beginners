namespace Simple_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();

            // Sum array
            int[] nums = { 1, 5, 8, 25 };
            Console.WriteLine(SumArray(nums));

            // Reverse string
            string rs = ReverseString("Olivia");
            Console.WriteLine(rs);
            
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
    }
}