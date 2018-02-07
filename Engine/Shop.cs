using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Shop : Location
    {
        public readonly List<Item> forSale = new List<Item>();

        public Shop(int id, string name, string description, List<Item> ForSale) : base(id, name, description)
        {
            forSale = ForSale;
        }

        public Item ItemByID(int id)
        {
            foreach (Item item in forSale)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
