using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using Xunit;

namespace MenuTest.Drinks
{
  public class WaterTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water w = new Water();
            Assert.Equal(0.10, w.Price);
        }
        [Fact]
        public void ShouldHaveTheDefaultCalories()
        {
            Water w = new Water();
            Assert.Equal<uint>(0,w.Calories);
        }
        [Fact]
        public void ShouldHaveTheDefaultSize()
        {
            Water w=new Water();
            Assert.Equal(Size.Small, w.Size);
        }
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Water w = new Water();
            Assert.True(w.Ice);
        }
        [Fact]

        public void ShouldHaveDefaultLemon()
        {
            Water w = new Water();
            Assert.False(w.Lemon);

        }
        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, w.Size);
        }
        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, w.Size);
        }
        [Fact]
        public void ThecorrectpriceAfterChangingToMeduim()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal(0.10, w.Price);
        }
        [Fact]
        public void ThecorrectpriceAfterChangingToLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal(0.10, w.Price);
        }
        [Fact]
        public void ThecorrectCaloriesAfterChangingToMeduim()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<uint>(0, w.Calories);
        }
        [Fact]
        public void ThecorrectCaloriesAfterChangingToLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<uint>(0, w.Calories);
        }
        public void ShouldHaveCorrectIngedients()
        {
            Water w = new Water();
            Assert.Contains<string>("Water", w.Ingredients);
            Assert.Contains<string>("Ice", w.Ingredients);
            Assert.Equal<int>(2, w.Ingredients.Count);
        }
        [Fact]

        public void HoldIceShouldRemoveIce()
        {
            Water w = new Water();
            w.HoldIce();
            Assert.False(w.Ice);
            Assert.DoesNotContain<string>("Ice", w.Ingredients);
        }
        [Fact]

        public void AddLemonShouldAddLemon()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.Contains<string>("Lemon", w.Ingredients);
            Assert.Equal<int>(2, w.Ingredients.Count);


        }




    }
}
