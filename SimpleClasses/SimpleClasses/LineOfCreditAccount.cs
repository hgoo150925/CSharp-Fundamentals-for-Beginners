namespace SimpleClasses
{
    // LineOfCreditAccount extiende (hereda) de BankAccount
    public class LineOfCreditAccount : BankAccount
    {
        public LineOfCreditAccount(string name, decimal initialBalance) : base(name, initialBalance) { }

        public override void PerformMonthEndTransactions()
        {
            // El código niega el saldo para calcular un cargo de interés positivo que se retira de la cuenta
            if (Balance < 0)
            {
                // Negate the balance to get a positive interest charge:
                decimal interest = -Balance * 0.07m;
                MakeWithdrawal(interest, DateTime.Now, "Charge monthly interest");
            }
        }
    }

    
}

