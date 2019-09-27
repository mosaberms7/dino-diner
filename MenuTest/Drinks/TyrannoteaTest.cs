using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
   public class TyrannoteaTest
    {
        [Fact]
      public void ShouldHaveCorrectDefaultPrice()
        {
             Tyrannotea t = new Tyrannotea();
            Assert.Equal(0.99, t.Price);
        }
        [Fact]
      public void ShouldHaveDefaultSweet()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.False(t.Sweet);
        }
        [Fact]
      public void ShouldHaveDefaultLemon()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.False(t.Lemon);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.Equal<uint>(8, t.Calories);
        }
        public void ShouldHaveCorrectIngedients()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.Contains<string>("Water", t.Ingredients);
            Assert.Contains<string>("Tea", t.Ingredients);
            Assert.Contains<string>("Sweet", t.Ingredients);
            Assert.Equal<int>(3, t.Ingredients.Count);
        }
        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea t = new Tyrannotea();

            Assert.Equal<Size>(Size.Small, t.Size);
        }
        public void ShouldUseCorrectPriceForMedium()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            Assert.Equal(1.49, t.Price);
        }
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            Assert.Equal<uint>(16, t.Calories);
        }
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, t.Size);
        }
        public void ShouldUseCorrectPriceForLarge()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Large;
            Assert.Equal(1.99, t.Price);
        }
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Large;
            Assert.Equal<uint>(32, t.Calories);
        }
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, t.Size);
        }
        public void HoldIceShouldRemoveIce()
        {
            Tyrannotea t = new Tyrannotea();
            t.HoldIce();
            Assert.DoesNotContain<string>("Ice", t.Ingredients);
        }
        public void AddLemonshouldaddLemon()
        {
            Tyrannotea t = new Tyrannotea();
            t.AddLemon();
            Assert.Contains<string>("Lemon", t.Ingredients);
            Assert.Equal<int>(4, t.Ingredients.Count);

        }

    }
}
