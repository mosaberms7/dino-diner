using System;
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
         

        }
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.Equal(1.50, jj.Price);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.True(jj.Ice);
        }


        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.Equal<uint>(112, jj.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            JurrasicJava jj = new JurrasicJava();

            Assert.Contains<string>("Water", jj.Ingredients);
            Assert.Contains<string>("Natural Flavors", jj.Ingredients);
            Assert.Contains<string>("Cane Sugar", jj.Ingredients);
            Assert.Equal<int>(3, jj.Ingredients.Count);
        }
        //the correct price after setting to small, meduim, large
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {

            JurrasicJava jj = new JurrasicJava();
            
            jj.Size = Size.Small;
            Assert.Equal<double>(1.50, jj.Price);

        }
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMeduim()
        {

            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Medium;
            Assert.Equal<double>(0.99, jj.Price);

        }
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Large;
            Assert.Equal<double>(1.49, jj.Price);
        }
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Small;
            Assert.Equal<uint>(2, jj.Calories);
        }
        public void ShouldHaveCorrectCaloriesAfterSettingMeduim()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Medium;
            Assert.Equal<uint>(4, jj.Calories);
        }
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Large;
            Assert.Equal<uint>(8, jj.Calories);
        }


    }

}

