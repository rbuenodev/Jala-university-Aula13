namespace Jala_university_Aula13.Models
{
    public interface IWallet
    {
        int Id { get; set; }
        decimal Balance { get; set; }
        void AddToBalance(decimal amout);
    }
}
