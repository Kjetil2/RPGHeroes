using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes
{
    //Armor class is child of the class Item
    public class Armor : Item 
    {
        // Creating public Constructer for Armor
        public Armor(string name, int requiredLevel, slot equipment) : base(name, requiredLevel, equipment)
        {
            // Tell which slot Weapon belongs to
            equipment = slot.Head;
            equipment = slot.Body;
            equipment = slot.Legs;
        }

        // Creating Property to Enumerator for ArmorType
        public ArmorType At { get; set; }
        

    }

    // Creating an Enumerator for ArmorType
    public enum ArmorType
        {
            Cloth,
            Leather,
            Mail,
            Plate
        }
    }
