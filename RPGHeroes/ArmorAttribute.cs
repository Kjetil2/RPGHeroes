using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes
{
    public class ArmorAttribute
    {
        private readonly int armor;

        //Declearing the variables for the Class ArmorAttribute
        public int Armor { get; set; }

        // Creating a Constructor with one Parameter
        public ArmorAttribute(int Armor)
        {
            Armor = armor;
        }

        // Creating a methode to Increase ArmorAttribute
        public void IncreaseAttribute(ArmorAttribute armorattribute)
        {
            Armor += armorattribute.Armor;
        }
    }


}

