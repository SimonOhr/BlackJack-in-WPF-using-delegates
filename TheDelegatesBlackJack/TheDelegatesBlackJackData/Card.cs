
namespace TheDelegatesBlackJackData
{
    public enum CardType { Numerical, Jack, Queen, King, Ace }
    public class Card
    {
        public string Suit { get; private set; }
        public int Value { get; private set; }
        public int SecondValue { get; private set; }
        public CardType type;
        public Card(string _suit, int _value, CardType _type)
        {
            Suit = _suit;
            Value = _value;
            type = _type;
            SecondValue = 0;

            switch (type)
            {
                case CardType.Numerical:
                    break;
                case CardType.Jack:
                    Value = 10;
                    break;
                case CardType.Queen:
                    Value = 10;
                    break;
                case CardType.King:
                    Value = 10;
                    break;
                case CardType.Ace:
                    Value = 11;
                    SecondValue = 1;
                    break;
                default:
                    break;
            }
        }
    }
}
