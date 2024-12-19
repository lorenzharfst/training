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
    public string Owner { get; set; }
    private List<Transaction> _allTransactions = new List<Transaction>();
    private readonly decimal _minimumBalance;
    public decimal Balance 
    { 
        get
        {
            decimal balance = 0;
            foreach (Transaction item in _allTransactions)
            {
                balance += item.Amount;
            }

            return balance;
        }
    }

    public BankAccount(string owner, decimal initialBalance) : this(owner, initialBalance, 0)
    {
        if (initialBalance < _minimumBalance)
        {
            throw new NegativeBalanceException("Initial balance can't be negative.");
        }
        Owner = owner;
        Transaction initialDeposit = new Transaction(initialBalance, "Initial Balance.");
        _allTransactions.Add(initialDeposit);
        Number = s_accountNumberSeed.ToString();
        s_accountNumberSeed++;
    }

    public BankAccount(string owner, decimal initialBalance, decimal minimumBalance)
    {
        Owner = owner;
        Number = s_accountNumberSeed.ToString();
        s_accountNumberSeed++;
        _minimumBalance = minimumBalance;

        if (minimumBalance > 0) MakeDeposit(minimumBalance, "Initial Balance.");
    }

    public void MakeDeposit(decimal amount, string note)
    {
        if (amount < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Deposit amount can't be negative");
        }
        Transaction deposit = new Transaction(amount, note);
        _allTransactions.Add(deposit);
    }

    public void MakeWithdrawal(decimal amount, string note)
    {
        if (amount < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal amount must be positive");
        }
        Transaction? transactionOverdraft = CheckWithdrawalLimit(Balance - amount < _minimumBalance);
        Transaction withdrawal = new Transaction(-amount, note);
        _allTransactions.Add(withdrawal);
        if (transactionOverdraft is not null)
        {
            _allTransactions.Add(transactionOverdraft);
        }
    }

    public virtual void PerformMonthEndTransactions(){}

    public string GetAccountHistory()
    {
        var report = new System.Text.StringBuilder();
        decimal balance = 0;
        foreach (Transaction transaction in _allTransactions)
        {
            balance += transaction.Amount;
            report.AppendLine($"{transaction.Date}:\t{transaction.Amount}\tBalance:{balance}\tNote: {transaction.Note}");
        }

        return report.ToString();
    }

    protected virtual Transaction? CheckWithdrawalLimit(bool isOverdrawn)
    {
        if (isOverdrawn)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }
        else 
        {
            return default;
        }
    }
}
