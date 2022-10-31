namespace Jala_university_Aula13.Models
{
    public class Currency : ICurrency
    {
        public Dictionary<string, decimal> List { get; set; } = new Dictionary<string, decimal>()
        {
        {"USD", 0.18M},
        {"CAD", 0.90M},
        {"EUR", 0.20M},
        };
    }
}
