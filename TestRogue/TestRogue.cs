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

            Rogue Rogue = new rogue("Kjetil");

            // Arrange 
            HeroAttribute expected = new HeroAttribute(1, 1, 8);

            //Act
            HeroAttribute actual = new HeroAttribute(1, 1, 5);



            //Assert
            Assert.Equal(expected.ToString(), actual.ToString());

        }

    }
}