public class TransactionManager
{
    // Method that withdraws funds, using ref to modify the balance
    public void Withdraw(ref decimal balance, decimal amount)
    {
        if (amount > balance)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }
        balance -= amount;
        Console.WriteLine($"Withdrawal successful. New balance: {balance:C}");
    }
}
