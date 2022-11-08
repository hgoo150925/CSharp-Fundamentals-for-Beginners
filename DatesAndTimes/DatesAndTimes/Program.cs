namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToString().Substring(0,5));
            Console.WriteLine(myValue.ToShortDateString());
            Console.WriteLine(myValue.ToLongDateString());
            Console.WriteLine(myValue.ToShortTimeString());
            Console.WriteLine(myValue.ToLongDateString());
            Console.WriteLine(myValue.ToLongTimeString());
            Console.WriteLine(myValue.AddDays(4).ToLongDateString());
            Console.WriteLine(myValue.Month);

            DateTime someDate = new DateTime(1955, 08, 15);
            Console.WriteLine(someDate);

            // Convertir una fecha en string
            DateTime dateString = DateTime.Parse("14/11/2022");
            Console.WriteLine(dateString);

            // Contar el total de días a partir de una fecha dada
            TimeSpan myAge = DateTime.Now.Subtract(someDate);
            Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();
        }
    }
}
