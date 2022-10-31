using Jala_university_Aula13.Models;

namespace Jala_university_Aula13.Service
{
    public class WalletService : IWalletService
    {
        private IWallet _wallet;
        private Money _money;

        public WalletService(IWallet wallet, Money money)
        {
            _wallet = wallet;
            _money = money;
        }

        public void AddMoneyToWallet(decimal amount)
        {
            _wallet.AddToBalance(amount);
        }

        public Tuple<string, decimal> ExchangeMoney(string money, decimal amount)
        {
            return _money.Exchange(money, amount);
        }

        public decimal GetAvailableMoney()
        {
            return _wallet.Balance;
        }
    }
}
