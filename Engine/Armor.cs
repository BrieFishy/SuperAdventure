using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Armor:Item
    {
        public int Strength;
        public string Type;

        public Armor (int id, string name, string namePlural, int value, int strength, string type) : base (id, name, namePlural, value)
        {
            Strength = strength;
            Type= type;
        }
    }
}
