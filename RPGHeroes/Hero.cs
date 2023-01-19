using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes
{
    public abstract class Hero
    {

        //Declearing the variables for the class Hero

        public string Name { get; set; }
        public int Level { get; set; } = 1; // Setting a default Level to 1.
        public HeroAttribute LevelAttributes { get; set; }
        public Dictionary<slot, Item> Equipment { get; set; }
        public List<WeaponType> validWeaponTypes { get; set; }
        public List<ArmorType> validArmorTypes { get; set; }


        // Creating a default Constructor
        public Hero()
        {
        }

        // Creating an Overloaded Constructor
        public Hero(string name)
        {
            Name = name;
        }

        // Creating an Abstract Methode for level up
        public abstract void LevelUp(int level);

        // Creating a Methode to set all the Equipment to a deafult Value null
        public void slotEquipment()
        {
            Equipment = new Dictionary<slot, Item>();
            Equipment.Add(slot.Weapon, null);
            Equipment.Add(slot.Head, null);
            Equipment.Add(slot.Body, null);
            Equipment.Add(slot.Legs, null);
        }

        //Creating an Abstract Methode for Equip Weapon with one Parameter
        public abstract void Equip(Weapon weapon);

        //Creating an Abstract Methode for Equip Armor with one Parameter
        public abstract void Equip(Armor armor);


        // Creating a StringBuilder in a public Methode to return Hero state
        public void HeroDisplay()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Heroname are {Name}");
            sb.AppendLine($"Heroclass are ");
            sb.AppendLine($"Herolevel are {Level}");
            sb.AppendLine($"Heroes total strength are ");
            sb.AppendLine($"Heroes total dexterity are ");
            sb.AppendLine($"Heroes total intelligence are ");
            sb.AppendLine($"Heroes total Damage are ");
            Console.WriteLine(sb);
        }

        






    }




            


    }


