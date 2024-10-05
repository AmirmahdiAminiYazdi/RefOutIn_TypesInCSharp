public class BankAccount
{
    public int AccountId { get; }
    public string AccountHolder { get; }

    // Use a public field for the balance
    public decimal BalanceField;

    public BankAccount(int accountId, string accountHolder, decimal initialBalance)
    {
        AccountId = accountId;
        AccountHolder = accountHolder;
        BalanceField = initialBalance;  // Initialize the balance
    }
}
