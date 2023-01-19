using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes
{
    //Mage class is child of the class Hero
    public class Mage : Hero
    {
        // Get the Attribute from HeroAttribute
        public HeroAttribute Attribute { get; set; }

        //Creating a public Constructor for Mage
        public Mage(string name) : base(name)
        {
            LevelAttributes = new HeroAttribute(1, 1, 8);
            
        }

        //Creating Override Methode for Level up with one Parameter
        public override void LevelUp()
        {
            Level += 1;
            LevelAttributes.IncreaseAttribute(new HeroAttribute(1, 1, 5));
        }

        // Creating Override Methode for Equip Weapon with one Parameter
        public override void Equip(Weapon weapon)
    
            // Creating Exception to see if Level is higher than requiredlevel
        {
            try
            {
                if (weapon.requiredLevel > Level) ;
            }
            // invoke the Methode InvalidWeaponException from the class InvalidWeaponException
            catch (Exception)
            {
                
                InvalidWeaponException.WeaponException();

            }

            // Creating Exception to see if WeaponType is Staffs or Wands
            try
            {
                if (weapon.Wt == WeaponType.Staffs)
                {
                    Equipment[weapon.equipment] = weapon;
                }
                else if (weapon.Wt == WeaponType.Wands)
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
                if (armor.requiredLevel > Level);
            }

            // invoke the Methode InvalidWeaponException from the class InvalidWeaponException

            catch (Exception) 
            {
                InvalidArmorException.ArmorException();
            }

            // Creating Exception to see if ArmorType is Cloth 

            try
            {
                if (armor.At == ArmorType.Cloth)
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

        
