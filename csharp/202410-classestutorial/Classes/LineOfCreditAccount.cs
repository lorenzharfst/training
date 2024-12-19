namespace Classes;

public class LineOfCreditAccount : BankAccount
{
    public LineOfCreditAccount(string owner, decimal initialBalance, decimal minimumBalance) : base(owner, initialBalance, minimumBalance) { }

    public override void PerformMonthEndTransactions()
    {
        if (Balance < 0)
        {
            decimal interestToWithdraw = -Balance * 0.07m;
            MakeWithdrawal(interestToWithdraw, "Negative overespending interest.");
        }
    }

    protected override Transaction? CheckWithdrawalLimit(bool isOverdrawn) => isOverdrawn ? new Transaction(-20, "Overdraft fee.") : default;
}
