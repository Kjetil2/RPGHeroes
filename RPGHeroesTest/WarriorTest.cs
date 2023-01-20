using RPGHeroes;
using System;
using System.Diagnostics;
using Xunit;

namespace RPGHeroesTest
{
    // Creating a test class
    public class WarriorTest
    {
        [Fact]
        
        //Creating a new test Methode
        public void WarriorLevelUp_AddoneLevel_ShouldReturnLevelPlussOne()
        
        {

            Warrior warrior = new Warrior("Kjetil");
            
            // Arrange 
            HeroAttribute expected = new HeroAttribute(5, 2, 1);

            //Act
            HeroAttribute actual = new HeroAttribute(3,2,1);
            


            //Assert
            Assert.Equal(expected.ToString(), actual.ToString());
            
        }

    }
}