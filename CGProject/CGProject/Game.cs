using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject
{
    /*
     * Class that defines every game
     * Manfact
     * List of Cards 
     * int GID
     * 
     * */
    public class Game
    {
        private string GameName;
        private string MadeBy;
        private string GId;
        private List<Card> Deck;
        public Game(string gameName, string madeBy, string gID, List<Card> Deck)
        {
            this.GameName = gameName;
            this.MadeBy = madeBy;
            this.GId = gID;
            this.Deck = Deck;
        }
        public string GetName()
        {
            return GameName;
        }
        public string GetMadeBy()
        {
            return MadeBy;
        }
        public string GetGId()
        {
            return GId;
        }
       
    }
}
