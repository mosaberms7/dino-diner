using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;


namespace MenuTest.Drinks
{
  public  class JurrasicJavaTest

    {
        [Fact]
        public void ShouldBeAbleToSetICetofalse()
        {
            JurassicJava jj = new JurassicJava();
            jj.Ice = false;
         

        }
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Equal<double>(0.59, jj.Price);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurassicJava jj = new JurassicJava();
            Assert.False(jj.Ice);
        }


        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Equal<uint>(2, jj.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            JurassicJava jj = new JurassicJava();

            Assert.Contains<string>("Water", jj.Ingredients);
            Assert.Contains<string>("Coffee", jj.Ingredients);
            Assert.Equal<int>(2, jj.Ingredients.Count);
        }
        //the correct price after setting to small, meduim, large
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {

            JurassicJava jj = new JurassicJava();
            
            jj.Size = Size.Small;
            Assert.Equal<double>(0.59, jj.Price);

        }
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMeduim()
        {

            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            Assert.Equal<double>(0.99, jj.Price);

        }
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Large;
            Assert.Equal<double>(1.49, jj.Price);
        }
        [Fact]

        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Small;
            Assert.Equal<uint>(2, jj.Calories);
        }
        [Fact]

        public void ShouldHaveCorrectCaloriesAfterSettingMeduim()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            Assert.Equal<uint>(4, jj.Calories);
        }
        [Fact]

        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Large;
            Assert.Equal<uint>(8, jj.Calories);
        }
        [Fact]

        public void ShouldBeAbleToSetSizeToMedium()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, jj.Size);
        }
        [Fact]

        public void ShouldBeAbleToSetSizeToLarge()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, jj.Size);
        }
        [Fact]

        public void ShouldDefaultHaveNOroomforCream()
        {
            JurassicJava jj = new JurassicJava();
            Assert.False(jj.RoomForCream);
        }
        [Fact]

        public void ShouldtHaveRoomforCream()
        {
            JurassicJava jj = new JurassicJava();
            jj.LeaveRoomForCream();

            Assert.True(jj.RoomForCream);
        }
        [Fact]

        public void AddIceShouldAddIce()
        {
            JurassicJava jj = new JurassicJava();
            jj.AddIce();
            Assert.True(jj.Ice);
            Assert.Contains<string>("Ice", jj.Ingredients);
            Assert.Equal<int>(3, jj.Ingredients.Count);

        }

    }

}

