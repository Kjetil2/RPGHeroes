using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes
{
    public class InvalidWeaponException:Exception
    {
        //Creating a public Methode for WeaponException
        public static void WeaponException()
        {
            Console.WriteLine("You can not Equip this Weapon");
        }

    }

}
