﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;


namespace MenuTest.Drinks
{
  public  class JurrasicJavaTest

    {
        [Fact]
        public void ShouldBeAbleToSetICetofalse()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Ice = false;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, ss.Flavor);

        }
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus ss = new Sodasaurus();
            Assert.Equal(1.50, ss.Price);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Sodasaurus ss = new Sodasaurus();
            Assert.True(ss.Ice);
        }


        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Sodasaurus ss = new Sodasaurus();
            Assert.Equal<uint>(112, ss.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Sodasaurus ss = new Sodasaurus();
            Assert.Contains<string>("Water", ss.Ingredients);
            Assert.Contains<string>("Natural Flavors", ss.Ingredients);
            Assert.Contains<string>("Cane Sugar", ss.Ingredients);
            Assert.Equal<int>(3, ss.Ingredients.Count);
        }
        //the correct price after setting to small, meduim, large
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {

            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<double>(1.50, soda.Price);

        }
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMeduim()
        {

            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<double>(2.00, soda.Price);

        }
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {

            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<double>(2.50, soda.Price);

        }
    }

}
}
