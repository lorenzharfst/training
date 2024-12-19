namespace Classes;

public class Transaction
{
    public decimal Amount { get; }
    public DateTime Date { get; }
    public string Note { get; }

    public Transaction(decimal amount, string note)
    {
        Amount = amount;
        Date = DateTime.Now;
        Note = note;
    }
}
