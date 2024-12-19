namespace Classes;

public class GiftCardAccount : BankAccount
{
    public decimal _monthlyDeposit { get; set; }
    public GiftCardAccount(string owner, decimal initialBalance, decimal monthlyDeposit = 0) : base(owner, initialBalance)
    {
        _monthlyDeposit = monthlyDeposit;
    }

    public override void PerformMonthEndTransactions()
    {
        if (_monthlyDeposit != 0)
        {
            MakeDeposit(_monthlyDeposit, "Monthly gift deposit.");
        }
    }
}
