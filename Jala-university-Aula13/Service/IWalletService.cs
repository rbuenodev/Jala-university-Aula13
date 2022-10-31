namespace Jala_university_Aula13.Service
{
    public interface IWalletService
    {
        decimal GetAvailableMoney();
        Tuple<string, decimal> ExchangeMoney(string money, decimal amount);
        void AddMoneyToWallet(decimal amount);
    }
}
