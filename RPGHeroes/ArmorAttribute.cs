using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes
{
    public class ArmorAttribute
    {
        //Declearing the variables for the Class ArmorAttribute
        public int Health { get; set; }

        // Creating a Constructor with one Parameter
        public ArmorAttribute(int health)
        {
            Health = health;
        }

        // Creating a methode to Increase ArmorAttribute
        public void IncreaseAttribute(ArmorAttribute armorattribute)
        {
            Health += armorattribute.Health;
        }
    }

    
}
