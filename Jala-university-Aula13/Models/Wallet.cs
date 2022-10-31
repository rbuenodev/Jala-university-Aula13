namespace Jala_university_Aula13.Models;

public class Wallet : IWallet
{
    public int Id { get; set; }
    public const string WalletCurrency = "BRL";
    public decimal Balance { get; set; }

    public void AddToBalance(decimal amount)
    {
        Balance += amount;
    }
}