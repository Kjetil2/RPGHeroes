using RPGHeroes;
using System;
using System.Diagnostics;
using Xunit;

namespace RPGHeroesTest
{
    // Creating a test class
    public class RangerTest
    {
        [Fact]
        
        //Creating a new test Methode
        public void RangerLevelUp_AddoneLevel_ShouldReturnLevelPlussOne()
        
        {

            Ranger mage = new Ranger("Kjetil");
            
            // Arrange 
            HeroAttribute expected = new HeroAttribute(1, 7, 1);

            //Act
            HeroAttribute actual = new HeroAttribute(1,5,1);
            


            //Assert
            Assert.Equal(expected.ToString(), actual.ToString());
            
        }

    }
}