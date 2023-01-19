using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPGHeroes
{
    public class HeroAttribute
    {

        //declearing the variables for the class Hero
        public int Strength { get; set; }
        public int Dexterity { get; set; } 
        public int Intelligence { get; set; }


        // Creating a Constructor with three Parameter
        public HeroAttribute(int strength, int dexterity, int intelligence)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;

        }

        // Creating a Methode to Increase HeroAttribute
        public void IncreaseAttribute(HeroAttribute heroAttribute) 
        {
            Strength += heroAttribute.Strength;
            Dexterity+= heroAttribute.Dexterity;
            Intelligence+= heroAttribute.Intelligence;
        }

        
                

    }
}
