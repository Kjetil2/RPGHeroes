using RPGHeroes;
using System;
using System.Diagnostics;
using Xunit;

namespace RPGHeroesTest
{
    public class RogueTest
    {
        [Fact]
        public void RogueLevelUp_AddoneLevel_ShouldReturnLevelPlussOne()
        {
            {
                Rogue rogue = new Rogue("Kjetil");

                // Arrange 
                HeroAttribute expected = new HeroAttribute(2, 6, 1);

                //Act
                HeroAttribute actual = new HeroAttribute(1, 4, 1);



                //Assert
                Assert.Equal(expected, actual);


            }
        }
    }
}
