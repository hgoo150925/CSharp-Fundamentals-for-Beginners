namespace SimpleClasses
{
    class Program
    {
        // https://learn.microsoft.com/es-es/dotnet/csharp/fundamentals/tutorials/classes
        static void Main(string[] args)
        {
            var account = new BankAccount("Jonas", 1500);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner}");

            var account2 = new BankAccount("Smith", 950);
            Console.WriteLine($"Account {account2.Number} was created for {account2.Owner}");
            Console.ReadLine();


        }
    }
}
