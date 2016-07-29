using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            Card c1 = new Card(Face.Jack, Suit.Spades);
            Console.WriteLine(c1);

            Array suits = Enum.GetValues(typeof(Suit));
            Array faces = Enum.GetValues(typeof(Face));

            List<Card> Deck = new List<Card>();

            foreach (Suit s in suits)
            {
                foreach (Face f in faces)
                {
                    Deck.Add(new Card(f, s));
                }
            }

            Console.WriteLine();
            
            for(int i = 0; i <= 51; i++)
            {
                Console.WriteLine(Deck[i]);
            }

            Console.ReadLine();
        }

        public class Card
        {
            public Face face;
            public Suit suit;

            public Card(Face f, Suit s)
            {
                this.suit = s;
                this.face = f;
            }

            public override string ToString()
            {
                return $"{face} of {suit}";
            }
        }

        public enum Suit
        {
            Clubs,
            Spades,
            Hearts,
            Diamonds
        }

        public enum Face
        {
            Ace,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King
        }
    }
}
