namespace SimpleClasses
{
    // LineOfCreditAccount extiende (hereda) de BankAccount
    public class LineOfCreditAccount : BankAccount
    {
        // El constructor LineOfCreditAccount cambia el signo del parámetro creditLimit para que coincida con el significado del parámetro minimumBalance
        // Que se encuentra en el constructor de BankAccount
        public LineOfCreditAccount(string name, decimal initialBalance, decimal creditLimit) : base(name, initialBalance, -creditLimit) { }

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
        protected override Transaction? CheckWithdrawalLimit(bool isOverdrawn) => isOverdrawn ? new Transaction(-20, DateTime.Now, "Apply overdraft fee") : default;
    }

    
}

