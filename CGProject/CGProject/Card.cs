using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject
{
    class Card
    {
        private string Name;
        private string Cost;
        private string Value;
        private string Description;
        private string ImageName;

        public Card(string Name, string Value, string Description, string ImageName, string Cost)
        {
            this.Name = Name;
            this.Cost = Cost;
            this.Value = Value;
            this.Description = Description;
            this.ImageName = ImageName;
        }

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
    }
}
