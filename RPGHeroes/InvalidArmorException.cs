using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes
{
    public class InvalidArmorException: Exception
    {
        //Creating a public Methode for ArmorException
        public static void ArmorException()
        {
            Console.WriteLine("You can not Equip this Armor");
        }
    }
}
