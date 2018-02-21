using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Armor:Item
    {
        public int Strength;//cannot be more than 25
        public string Type;//Helmet, Breastplate, Shield, Pants

        public Armor (int id, string name, string namePlural, int value, int strength, string type) : base (id, name, namePlural, value)
        {
            Strength = strength;
            Type= type;
        }
    }
}
