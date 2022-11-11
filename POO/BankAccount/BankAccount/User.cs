namespace BankAccount;

public class User
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public decimal Balance { get; set; }
    public DateTime RegisterDate { get; set; }

    public User(int id, string name, string email, decimal balance, DateTime registerDate)
    {
        Name = name;
        Email = email;
        Balance = balance;
        RegisterDate = registerDate;
    }

    public string ShowData()
    {
        return $"Name: {Name} Email: {Email} Balance: {Balance} RegisterDate: {RegisterDate}";

    }


}