/* Bank Account supports this behaviour:
 * 1. It has a 10-digit number that uniquely identifies it
 * 2. It has a string that stores the name or names of owners
 * 3. The balance can be retrieved
 * 4. It accepts deposits.
 * 5. It accepts withdrawals.
 * 6. The initial balance must be positive.
 * 7. Withdrawals can't result in a negative balance.
 */

using CustomExceptions;

namespace Classes;

public class BankAccount
{
    private static int s_accountNumberSeed = 1234567890;
    public string Number { get; }
    public decimal Balance { get; }
    public string Owner { get; set; }

    public void MakeDeposit(decimal amount, string note)
    {
        Balance += amount;
        DateTime date = new DateTime();
        Console.WriteLine($"Deposit of {amount} succesful. Note: \"{note}\". Date: {date.ToString()}");
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
    }

    public BankAccount(string owner, decimal initialBalance)
    {
        if (initialBalance < 0)
        {
            throw new NegativeBalanceException("Initial balance can't be negative.");
        }
        Owner = owner;
        Balance = initialBalance;
        Number = s_accountNumberSeed.ToString();
        s_accountNumberSeed++;
    }
}
