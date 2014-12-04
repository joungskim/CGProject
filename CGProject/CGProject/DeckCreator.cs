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



        public Card createCard(string name, string value, string description, string imageName, string cost, string type)
        {
            Card card = new Card(name, value, description, imageName, cost, type);
            return card;
        }

        public List<Game> getGames()
        {
            return Games;
        }
    }
}
