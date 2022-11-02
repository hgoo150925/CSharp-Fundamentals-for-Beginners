using System;
using System.Text;

namespace Working_with_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Go to your c:\\ drive";
            Console.WriteLine(myString);

            string country = "Argentina";
            Console.WriteLine(country);

            string myStr = String.Format("{0:N}", 13.99);
            Console.WriteLine(myStr);

            string toUpper = "hello san francisco";
            Console.WriteLine(toUpper.ToUpper());

            string toLower = "Hello San Francisco";
            Console.WriteLine(toLower.ToLower());
            Console.WriteLine("toLower Length: " + toLower.Length);

            string trim = "                    hello los angeles            ";
            string trimStr = String.Format("Length before: {0} -- Length after: {1}", trim.Length, trim.Trim().Length);
            Console.WriteLine(trimStr);
            //Console.WriteLine("toLower Trim: " + trim.Trim());

            string myString1 = String.Format("{0} = {1}", "First", "Second");
            Console.WriteLine(myString1);

            int[] arrayNumber = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            string rs = String.Join("", arrayNumber);
            string myString2 = String.Format("Phone Number: {0:(###) ###-####}", int.Parse(rs));
            Console.WriteLine(myString2);

            int[] arrayNumber2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
            string res = CreatePhoneNumber(arrayNumber2);
            Console.WriteLine("Create Phone Number: " + res);

            string myName = "Lola";
            myName = myName.Substring(0, 2); // empieza en la posicion 0 y termina en la posicion 2 (0:L, 1:o, 2:L, 3:a)
            Console.WriteLine(myName);

            string myNum = "2554092135"; // (255) 409-2135
            Console.WriteLine($"({myNum.Substring(0, 3)}) {myNum.Substring(3, 3)}-{myNum.Substring(6)}");

            // String Builder
            // https://www.geeksforgeeks.org/stringbuilder-in-c-sharp/
            StringBuilder s = new StringBuilder();
            for (int i = 0; i <= 5; i++)
            {
                s.Append("-");
                s.Append(i);
            }
            Console.WriteLine(s);
            Console.ReadLine();
        }

        public static string CreatePhoneNumber(int[] numbers)
        {
            // 1234567890
            string rs = String.Join("", numbers);
            return String.Format("{0:(###) ###-####}", int.Parse(rs));          
            
        }
    }
}

