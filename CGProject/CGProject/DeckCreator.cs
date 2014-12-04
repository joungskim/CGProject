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



        public void createCard()
        {
            // need to read in something here, sql stuffs

            string name = "";
            string value = "";
            string description = "";
            string imageName = "";
            string cost = "";
            string type = "";

            Card card = new Card(name, value, description, imageName, cost, type);
            Cards.Add(card);
        }

        public List<Game> getGames()
        {
            return Games;
        }
    }
}
