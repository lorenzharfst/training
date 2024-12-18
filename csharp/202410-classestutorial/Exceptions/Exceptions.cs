namespace CustomExceptions;

[Serializable]

// Thrown when the initialBalance of a new BankAccount is negative
public class NegativeBalanceException : Exception
{
    public NegativeBalanceException() : base() 
    {
    }
    public NegativeBalanceException(string message) : base(message) { }
    public NegativeBalanceException(string message, Exception inner) : base(message, inner) { }
}
