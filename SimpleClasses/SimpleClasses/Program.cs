namespace SimpleClasses
{
    class Program
    {
        // https://learn.microsoft.com/es-es/dotnet/csharp/fundamentals/tutorials/classes
        static void Main(string[] args)
        {
            var account = new BankAccount("Jonas", 1250);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner}");

            var account2 = new BankAccount("Smith", 1340);
            Console.WriteLine($"Account {account2.Number} was created for {account2.Owner}");

            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine($"Make withdrawal: {account.Balance}");
            account.MakeDeposit(500, DateTime.Now, "Friend paid me back");
            Console.WriteLine($"Make deposit: {account.Balance}");
            Console.ReadLine();


        }
    }
}
