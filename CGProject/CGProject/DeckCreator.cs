using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject
{
    public class DeckCreator
    {
        private List<Game> Games = new List<Game>();
        private List<Card> Cards;



        public void addCard(Card card)
        {
            Cards.Add(card);
        }

        public List<Game> getGames()
        {
            return Games;
        }
    }
}
