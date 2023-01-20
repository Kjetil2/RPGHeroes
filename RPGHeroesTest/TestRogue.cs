using RPGHeroes;
using System;
using System.Diagnostics;
using Xunit;

namespace RPGHeroesTest
{
    // Creating a test class
    public class RogueTest
    {
        [Fact]

        //Creating a new test Methode
        public void RogueLevelUp_AddoneLevel_ShouldReturnLevelPlussOne()

        {

            Rogue Rogue = new Rogue("Kjetil");

            // Arrange 
            HeroAttribute expected = new HeroAttribute(2, 6, 1);

            //Act
            HeroAttribute actual = new HeroAttribute(1, 4, 1);



            //Assert
            Assert.Equal(expected.ToString(), actual.ToString());

        }

    }
}