
public class Program
{
    public static void Main()
    {
        var account = new BankAccount(1, "Amir", 5000m);
        var transactionManager = new TransactionManager();
        var creditChecker = new CreditChecker();
        var transactionLogger = new TransactionLogger();

        decimal withdrawalAmount = 1500m;
        creditChecker.CheckCredit(account, withdrawalAmount, out bool isCreditAvailable);

        if (isCreditAvailable)
        {
            // Withdraw using ref on the backing field
            transactionManager.Withdraw(ref account.BalanceField, withdrawalAmount);
            transactionLogger.LogTransaction(account, withdrawalAmount);
        }
        else
        {
            Console.WriteLine("Insufficient funds for this transaction.");
        }
    }
}
