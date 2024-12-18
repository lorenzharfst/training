using Classes;
using CustomExceptions;

public class Program
{
    public static void Main(string[] args)
    {
        try {
        BankAccount myBankAccount = new BankAccount("Lorentius", 200);
        Console.WriteLine($"Succesfully created Bank Account for: {myBankAccount.Owner}, with balance: {myBankAccount.Balance}");
        } catch (Exception ex)
        {
            if (ex is NegativeBalanceException)
            {
                Console.WriteLine("cum");
            }
            else
            {
                throw ex;
            }
        }
    }
}
