// La declaración namespace permite organizar el código de forma lógica
namespace SimpleClasses
{
    // https://learn.microsoft.com/es-es/dotnet/csharp/fundamentals/tutorials/classes
    // Este archivo va a contener la definición de una cuenta bancaria.
    // La programación orientada a objetos organiza el código creando tipos en forma de clases.
    // Estas clases contienen el código que representa una entidad específica.
    // La clase BankAccount representa una cuenta bancaria.
    // El código implementa operaciones específicas a través de métodos y propiedades.
    public class BankAccount
    {
        // Propiedades de la clase
        // Las propiedades son elementos de datos que pueden contener código que exige la validación u otras reglas
        public string Number { get; }
        public string Owner { get; }
        // public decimal Balance { get; }
        // Vamos a calcular Balance
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach(var item in _allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;

            }
        }

        // La palabra clave private es un modificador de acceso de miembro
        // Los miembros privados solo son accesibles dentro del cuerpo de la clase o el struct en el que se declaran
        // También es static, lo que significa que lo comparten todos los objetos BankAccount
        private static int s_accountNumberSeed = 1234567890;

        // El campo _minimumBalance está marcado como readonly. Esto significa que el valor no se puede cambiar después de que se construya el objeto
        private readonly decimal _minimumBalance;

        // Para crear un objeto de tipo BankAccount, es necesario definir un constructor que asigne esos valores. 
        // Un constructor es un miembro que tiene el mismo nombre que la clase. Se usa para inicializar los objetos de ese tipo de clase

        // La expresión : this() llama al otro constructor, el que tiene tres parámetros.
        // Esta técnica permite tener una única implementación para inicializar un objeto, aunque el código de cliente puede elegir uno de muchos constructores
        public BankAccount(string name, decimal initialBalance) : this(name, initialBalance, 0) { }
        public BankAccount(string name, decimal initialBalance, decimal minimumBalance)
        {
            Number = s_accountNumberSeed.ToString();
            s_accountNumberSeed++;

            Owner = name;
            _minimumBalance = minimumBalance;

            if (initialBalance > 0)
            {
                MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
            }
        }

        // Ahora se va a agregar List<T> de objetos Transaction
        // List<T> Clase: Representa una lista de objetos fuertemente tipados a la que se puede obtener acceso por índice.
        // Proporciona métodos para buscar, ordenar y manipular listas.
        private List<Transaction> _allTransactions = new List<Transaction>();

        // Metodos
        // Estos métodos aplicarán las dos reglas finales: el saldo inicial debe ser positivo, y ningún reintegro debe generar un saldo negativo
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }

            var deposit = new Transaction(amount, date, note);
            _allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }

            /*
            if (Balance - amount < _minimumBalance)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }

            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
            */
            Transaction? overdraftTransaction = CheckWithdrawalLimit(Balance - amount < _minimumBalance);
            Transaction? withdrawal = new(-amount, date, note);
            _allTransactions.Add(withdrawal);

            if (overdraftTransaction != null)
            {
                _allTransactions.Add(overdraftTransaction);
            }

        }

        // El método agregado es protected, lo que significa que solo se puede llamar desde clases derivadas.
        // Esa declaración impide que otros clientes llamen al método. También es virtual para que las clases derivadas puedan cambiar el comportamiento.
        // El tipo de valor devuelto es Transaction?. La anotación ? indica que el método puede devolver null
        protected virtual Transaction? CheckWithdrawalLimit(bool isOverdrawn)
        {
            if (isOverdrawn)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            else
            {
                return default;
            }
        }

        // El método GetAccountHistory crea string para el historial de transacciones.
        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in _allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }

            return report.ToString();
        }

        // https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/virtual
        // La palabra clave virtual se usa para modificar una declaración de método, propiedad, indizador o evento y permitir que se invalide en una clase derivada
        // Se usa la palabra clave virtual para declarar un método en la clase base para el que una clase derivada puede proporcionar una implementación diferente.
        // Un método virtual es un método en el que cualquier clase derivada puede optar por volver a implementar.
        // La palabra clave virtual especifica que las clases derivadas pueden invalidar el comportamiento.
        public virtual void PerformMonthEndTransactions()
        {

        }
    }
}
