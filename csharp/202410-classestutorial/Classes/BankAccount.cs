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
    public string Number { get; }
    public decimal Balance { get; }
    public string Owner { get; set; }

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
    }

    public BankAccount(string owner, decimal initialBalance)
    {
        if (initialBalance < 0)
        {
            throw new NegativeBalanceException("Balance can't be negative");
        }
        Owner = owner;
        Balance = initialBalance;
        Number = "202020202";
    }
}
