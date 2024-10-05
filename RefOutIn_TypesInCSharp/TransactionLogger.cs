public class TransactionLogger
{
    public void LogTransaction(in BankAccount account, decimal amount)
    {
        Console.WriteLine($"Transaction logged: {amount:C} from {account.AccountHolder} (Balance: {account.BalanceField:C})");
    }
}
