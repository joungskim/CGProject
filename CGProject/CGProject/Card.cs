using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


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

        private MySqlDataReader read;

        /*
         * Gets the cards from a specific game from the DB in alphabetical order
         */
        
         public void cardsAlpha(string GameID)
        {
            try { 
             //Server s = new Server()
             //read = s.querry(
            return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                //s.closeConnection()
            }
        }

         /*
          * Gets the cards from a specific game from the DB referenced by type in alphabetical order,then by name in alphabetical order
         */

         public void cardsTypeAlpha(string GameID)
         {

             return;
         }
         
        /*
         * Gets the cards from a specific game from the DB referenced by cost in increasing order,then by name in alphabetical order
         */

         public void cardsCostAlpha(string GameID)
         {

             return;
         }

         /*
          * Gets the cards from a specific game from the DB referenced by value in alphabetical order,then by name in alphabetical order
         */

         public void cardsValueAlpha(string GameID)
         {

             return;
         }

        /*
         *  Constructor to set values for cards.
         *  Decks will be rebuilt for every update to ensure that database is
         *  consistent with the displayed information.
         */
        private Card(string Name, string Value, string Description, string ImageName, string Cost, string Type)
        {
            this.Name = Name;
            this.Cost = Cost;
            this.Value = Value;
            this.Description = Description;
            this.ImageName = ImageName;
            this.Type = Type;
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
    }
}
