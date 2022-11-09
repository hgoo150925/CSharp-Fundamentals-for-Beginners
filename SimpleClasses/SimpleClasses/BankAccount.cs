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
        public decimal Balance { get; }

        // La palabra clave private es un modificador de acceso de miembro
        // Los miembros privados solo son accesibles dentro del cuerpo de la clase o el struct en el que se declaran
        // También es static, lo que significa que lo comparten todos los objetos BankAccount
        private static int accountNumberSeed = 1234567890;

        // Para crear un objeto de tipo BankAccount, es necesario definir un constructor que asigne esos valores. 
        // Un constructor es un miembro que tiene el mismo nombre que la clase. Se usa para inicializar los objetos de ese tipo de clase
        
        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner= name;
            this.Balance = initialBalance;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        // Tambien se puede declarar un constructor de esta forma
        /*
        public BankAccount(string name, decimal initialBalance)
        {
            Owner = name;
            Balance = initialBalance;
        }
        */

        // Metodos
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {

        }
    }
}
