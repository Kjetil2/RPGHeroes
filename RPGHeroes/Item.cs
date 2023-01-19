using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes
{
    public abstract class Item
    {
        //declearing the variables for the class Item
        public string name { get; set; }
        public int requiredLevel { get; set; }
        public slot equipment { get; set; }

        //Creating a protected Constructor for class Item with 3 Parameter
        protected Item(string name, int requiredLevel, slot equipment)
        {
            this.name = name;
            this.requiredLevel = requiredLevel;
            this.equipment = equipment;
        }

        /// Creating an Enumerator for Slot 
    }
    public enum slot
    {
        Weapon,
        Head,
        Body,
        Legs
    }
}


