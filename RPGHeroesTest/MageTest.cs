using RPGHeroes;
using System;
using System.Diagnostics;
using Xunit;

namespace RPGHeroesTest
{
    // Creating a test class
    public class MageTest
    {
        [Fact]
        
        //Creating a new test Methode
        public void MageLevelUp_AddoneLevel_ShouldReturnLevelPlussOne()
        
        {
            Mage mage = new Mage("Kjetil");
            
            // Arrange 
            HeroAttribute expected = new HeroAttribute(1, 1, 8);

            //Act
            HeroAttribute actual = new HeroAttribute(1,1,8);


            //Assert
            Assert.Equal(expected, actual);
            
        }

    }
}