namespace Classes;

public class InterestEarningAccount : BankAccount
{
    public InterestEarningAccount(string owner, decimal initialBalance) : base(owner, initialBalance) { }

    public override void PerformMonthEndTransactions()
    {
        if (Balance > 500m)
        {
            decimal interest = Balance * 0.02m;
            MakeDeposit(interest, "Monthly interest.");
        }
    }

}
