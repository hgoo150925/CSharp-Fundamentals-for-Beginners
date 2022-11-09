namespace SimpleClasses
{
    // InterestEarningAccount extiende (hereda) de BankAccount
    public class InterestEarningAccount : BankAccount
    {
        // Constructor
        public InterestEarningAccount(string name, string initialBalance) : base(name, initialBalance)
        {

        }

        // Las clases derivadas usan la palabra clave override para definir la nueva implementación
        // El metodo PerformMonthEndTransactions se hereda de BankAccount
        public override void PerformMonthEndTransactions()
        {
            if (Balance > 500m)
            {
                decimal interest = Balance * 0.05m;
                MakeDeposit(interest, DateTime.Now, "apply monthly interest");
            }
        }
    }
}

