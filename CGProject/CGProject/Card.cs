using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
*  This card class is the object of a card.    
*/

namespace CGProject
{
    public class Card
    {
        /*
         * Fields for properties that make up cards.    
         */

        private string Name;
        private string Cost;
        private string Value;
        private string Description;
        private string ImageName;
        private string Type;
        private string GameMaker;


        /*
         *  Constructor to set values for cards.
         *  Decks will be rebuilt for every update to ensure that database is
         *  consistent with the displayed information.
         */
        public Card(string Name, string Value, string Description, string ImageName, string Cost, string Type, string GameMaker)
        {
            this.Name = Name;
            this.Cost = Cost;
            this.Value = Value;
            this.Description = Description;
            this.ImageName = ImageName;
            this.Type = Type;
            this.GameMaker = GameMaker;
        }

        /*
         *  Getter methods for private fields.  
         */

        public string getName()
        {
            return Name;
        }

        public string getCost()
        {
            return Cost;
        }

        public string getValue()
        {
            return Value;
        }

        public string getDescription()
        {
            return ImageName;
        }

        public string getType()
        {
            return Type;
        }

        public string getGameMaker()
        {
            return GameMaker;
        }
    }
}
