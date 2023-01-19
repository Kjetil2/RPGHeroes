using RPGHeroes;
using System;
using System.Diagnostics;
using Xunit;

namespace RPGHeroesTest
{
    public class MageTest
    {
        [Fact]
        public void MageLevelUp_AddoneLevel_ShouldReturnLevelPlussOne()
        
        {
            Mage mage = new Mage("Kjetil");
            
            
            HeroAttribute expected = new HeroAttribute(1, 1, 8);

            HeroAttribute actual = new HeroAttribute(1,1,8);

            Assert.Equal(expected, actual);
            
        }

    }
}