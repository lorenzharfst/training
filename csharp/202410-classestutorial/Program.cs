using Classes;
using CustomExceptions;

public class Program
{
    public static void Main(string[] args)
    {
       var earningAccount = new InterestEarningAccount("Interest Account", 5000);
       earningAccount.MakeWithdrawal(20, "Coffe");
       earningAccount.MakeWithdrawal(50, "Coke");
       earningAccount.PerformMonthEndTransactions();
       Console.WriteLine(earningAccount.GetAccountHistory());

       var giftCardAccount = new GiftCardAccount("Gift Account", 5000, 20);
       giftCardAccount.MakeWithdrawal(20, "Coffe");
       giftCardAccount.MakeWithdrawal(50, "Coke");
       giftCardAccount.PerformMonthEndTransactions();
       Console.WriteLine(giftCardAccount.GetAccountHistory());

       var lineOfCreditAccount = new LineOfCreditAccount("Interest Account", 0, -2000);
       lineOfCreditAccount.MakeWithdrawal(20, "Coffe");
       lineOfCreditAccount.MakeWithdrawal(1550, "Coke");
       lineOfCreditAccount.MakeWithdrawal(5000, "Wedding ring");
       lineOfCreditAccount.PerformMonthEndTransactions();
       Console.WriteLine(lineOfCreditAccount.GetAccountHistory());
    }
}
