
public class CreditChecker
{
    public void CheckCredit(BankAccount account, decimal amount, out bool isCreditAvailable)
    {
        isCreditAvailable = account.BalanceField >= amount;
    }
}
