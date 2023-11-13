using CardGameBehavioralPatterrn.Models;
using CardGameBehavioralPatterrn.Repos;

namespace CardGameBehavioralPatterrn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card_Repo_EF cardRepo = new Card_Repo_EF();
            cardRepo.Create();
            ShowList(cardRepo.GetAll());
            Console.ReadLine();
        }
        static void ShowList(List<Minion> cards)
        {
            foreach (Minion minion in cards) 
            {
                Console.WriteLine($"{minion.Id}{minion.Name}");
            }
        }
    }
}