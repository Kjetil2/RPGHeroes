﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes
{
    //Ranger class is child of the class Hero
    public class Ranger : Hero
    {
        // Get the Attribute from HeroAttribute

        public HeroAttribute Attribute { get; set; }

        //Creating a public Constructor for Ranger
        public Ranger(string name) : base(name)
        {
            LevelAttributes = new HeroAttribute(1, 7, 1);
        }

        //Creating Override Methode for Level up with one Parameter
        public override void LevelUp()
        {
            Level += 1;
            LevelAttributes.IncreaseAttribute(new HeroAttribute(1, 5, 1));
        }

        // Creating Override Methode for Equip Weapon with one Parameter
        public override void Equip(Weapon weapon)
        {
            // Creating Exception to see if Level is higher than requiredlevel

            try
            {
                if (weapon.requiredLevel > Level);
            }
            // invoke the Methode InvalidWeaponException from the class InvalidWeaponException
            catch (Exception)
            {

                InvalidWeaponException.WeaponException(); 
            }

            // Creating Exception to see if WeaponType is Bows 
            try
            {
                if (weapon.Wt == WeaponType.Bows)
                {
                    Equipment[weapon.equipment] = weapon;
                }
            }
            // invoke the Methode InvalidWeaponException from the class InvalidWeaponException
            catch (Exception) 
            {
                InvalidWeaponException.WeaponException();
            }

       
        }
        // Creating Override Methode for Equip with one Parameter
        public override void Equip(Armor armor)
        {
            // Creating Exception to see if Level is higher than requiredlevel
            try
            {
                if (armor.requiredLevel > Level) ;
            }
            // invoke the Methode InvalidWeaponException from the class InvalidWeaponException
            catch (Exception)
            {

                InvalidArmorException.ArmorException();
            }

            // Creating Exception to see if ArmorType is Leather or Mail 
            try
            {
                if (armor.At == ArmorType.Leather)
                {
                    Equipment[armor.equipment] = armor;
                }
                else if (armor.At == ArmorType.Mail)
                {
                    Equipment[armor.equipment] = armor;
                }
            }
            // invoke the Methode InvalidWeaponException from the class InvalidWeaponException
            catch (Exception)
            {

                InvalidArmorException.ArmorException();
            }


        }
    }
}
