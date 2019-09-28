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
            Assert.Equal<double>(0.59, jj.Price);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.False(jj.Ice);
        }


        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.Equal<uint>(2, jj.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            JurrasicJava jj = new JurrasicJava();

            Assert.Contains<string>("Water", jj.Ingredients);
            Assert.Contains<string>("Coffee", jj.Ingredients);
            Assert.Equal<int>(2, jj.Ingredients.Count);
        }
        //the correct price after setting to small, meduim, large
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {

            JurrasicJava jj = new JurrasicJava();
            
            jj.Size = Size.Small;
            Assert.Equal<double>(0.59, jj.Price);

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
        [Fact]

        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Small;
            Assert.Equal<uint>(2, jj.Calories);
        }
        [Fact]

        public void ShouldHaveCorrectCaloriesAfterSettingMeduim()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Medium;
            Assert.Equal<uint>(4, jj.Calories);
        }
        [Fact]

        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Large;
            Assert.Equal<uint>(8, jj.Calories);
        }
        [Fact]

        public void ShouldBeAbleToSetSizeToMedium()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, jj.Size);
        }
        [Fact]

        public void ShouldBeAbleToSetSizeToLarge()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, jj.Size);
        }
        [Fact]

        public void ShouldDefaultHaveNOroomforCream()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.False(jj.RoomForCream);
        }
        [Fact]

        public void ShouldtHaveRoomforCream()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.LeaveRoomForCream();

            Assert.True(jj.RoomForCream);
        }
        [Fact]

        public void AddIceShouldAddIce()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.AddIce();
            Assert.True(jj.Ice);
            Assert.Contains<string>("Ice", jj.Ingredients);
            Assert.Equal<int>(3, jj.Ingredients.Count);

        }

    }

}

