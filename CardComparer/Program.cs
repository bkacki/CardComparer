using CardEnum;

namespace CardComparer
{
    internal class Program
    {
        private static readonly Random random = new Random();

        static void Main(string[] args)
        {
            List<Card> deck = new List<Card>();
            Console.Write("Podaj liczbę kart: ");
            if(int.TryParse(Console.ReadLine(), out int numberOfCards))
                for (int i = 0; i < numberOfCards; i++)
                    deck.Add(RandomCard());
            PrintCards(deck);

            Console.WriteLine("\n--- SORTOWANIE KART ---\n");

            IComparer<Card> comparer = new CardComparerByValue();
            deck.Sort(comparer);
            PrintCards(deck);
        }

        static void PrintCards(List<Card> deckToPrint)
        {
            foreach(Card card in deckToPrint)
                Console.WriteLine($"{card.Name}");
        }

        static Card RandomCard()
        {
            return new Card((Values)random.Next(1,14), (Suits)random.Next(4));
        }
    }
}
