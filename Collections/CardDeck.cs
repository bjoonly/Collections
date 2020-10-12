using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
 
       public enum SuitCard { Diamonds, Hearts, Spades, Clubs };
        public enum RankCard { Six,Seven,Eight,Nine,Ten, Jack,Queen,King,Ace};
        struct Card
        {
            public SuitCard Suit { get; set; }
            public RankCard Rank { get; set; }
            public Card(SuitCard suit, RankCard rank)
            {
                Suit = suit;
                Rank = rank;
            }
            public override string ToString()
            {
            return "{"+Rank.ToString()+" " + Suit.ToString()+"}";
                
            }
        }
    class CardDeck
    {
        private Queue<Card> cardDeck;
        public CardDeck()
        {
            cardDeck = new Queue<Card>(36);
            FillCardDeck();
        }
        public void FillCardDeck()
        {
            if (cardDeck.Count != 0)
                cardDeck.Clear();
            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    cardDeck.Enqueue(new Card((SuitCard)j, (RankCard)i));
                }
            }
        }

        public void Show()
        {
            int count = 1;
            foreach(Card card in cardDeck)
            {

                Console.Write(card+" ");

                if(count%4==0)
                    Console.WriteLine();
                count++;
            }
        }
        public void TakeCard()
        {
            if (cardDeck.Count == 0)
                throw new InvalidOperationException("There are no cards in the deck.");
            Console.WriteLine("\nYou got the card: "+cardDeck.Dequeue());

        }
        public void Deal6Cards()
        {
            if (cardDeck.Count < 6)
                throw new InvalidOperationException("The deck has less than 6 cards.");
            Console.WriteLine();
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine(i+1+" "+cardDeck.Dequeue());
            }
        }
        public void ShuffleDeck()
        {

            if (cardDeck.Count == 0)
                throw new InvalidOperationException("There are no cards in the deck.");
            List<Card> res = new List<Card>(cardDeck.ToList());
            cardDeck.Clear();
            Random random = new Random();
            for(int i = res.Count - 1; i >= 0; i--)
            {

                int j = random.Next(i + 1);
                Card tmp = res[j];
                res[j] = res[i];
                res[i] = tmp;
            }
            cardDeck = new Queue<Card>(res);
        }

    }
}
