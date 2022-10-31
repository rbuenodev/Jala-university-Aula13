namespace Jala_university_Aula13.Models
{
    public class Money
    {
        private readonly ICurrency _currency;
        private IWallet _walletService;

        public Money(ICurrency currency, IWallet wallet)
        {
            _currency = currency;
            _walletService = wallet;
        }

        public Tuple<string, decimal> Exchange(string outgoingCurrency, decimal amount)
        {
            if (!_currency.List.TryGetValue(outgoingCurrency, out var to))
            {
                throw new ArgumentException("Invalid currency");
            }

            if (amount < 50)
            {
                throw new InvalidOperationException("amount below expected");
            }

            if (amount > _walletService.Balance)
            {
                throw new ArgumentException();
            }

            var total = amount * to - 0.01M;
            return new Tuple<string, decimal>(outgoingCurrency, total);
        }
    }
}
