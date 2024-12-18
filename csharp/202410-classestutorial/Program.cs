using Classes;
using CustomExceptions;

public class Program
{
    public static void Main(string[] args)
    {
        var newUsers = new(string owner, decimal initialBalance) []
        {
            ("Lorenz", -200),
            ("Peter", 900),
            ("Johan", 240)
        };
        foreach (var person in newUsers)
        {
            try {
            BankAccount myBankAccount = new BankAccount(person.owner, person.initialBalance);
            Console.WriteLine($"Succesfully created Bank Account for: {myBankAccount.Owner}, with balance: {myBankAccount.Balance}.");
            } catch (Exception ex)
            {
                if (ex is NegativeBalanceException)
                {
                    Console.WriteLine($"Error creating BankAccount for {person.owner}: {ex.Message}");
                }
                else
                {
                    throw;
                }
            }
        }
    }
}
