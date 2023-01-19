using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes
{
    //Weapon class is child of the class Item
    public class Weapon : Item
    {
        // WeaponDamage Variabel
        public int WeaponDamage { get; set; } = 1; //Default vale equals to 1

        // Creating public Constructer for Weapon
        public Weapon(string name, int requiredLevel, slot equipment) : base(name, requiredLevel, equipment)
        {
            // Tell which slot Weapon belongs to
            equipment = slot.Weapon;
            

        }
        // Creating Property to Enumerator for WeaponType
        public WeaponType Wt { get; set; }





        
    }
    public enum WeaponType
    {
        Axes,
        Bows,
        Daggers,
        Hammers,
        Staffs,
        Swords,
        Wands
    }

}
