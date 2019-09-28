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
        [Fact]

        public void ShouldHaveCorrectIngedients()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.Contains<string>("Water", t.Ingredients);
            Assert.Contains<string>("Tea", t.Ingredients);
           
            Assert.Equal<int>(2, t.Ingredients.Count);
        }
        [Fact]

        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea t = new Tyrannotea();

            Assert.Equal<Size>(Size.Small, t.Size);
        }
        [Fact]

        public void ShouldUseCorrectPriceForMedium()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            Assert.Equal(1.49, t.Price);
        }
        [Fact]

        public void ShouldUseCorrectCaloriesForMedium()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            Assert.Equal<uint>(16, t.Calories);
        }
        [Fact]

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
        [Fact]

        public void ShouldUseCorrectCaloriesForLarge()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Large;
            Assert.Equal<uint>(32, t.Calories);
        }
        [Fact]

        public void ShouldBeAbleToSetSizeToLarge()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, t.Size);
        }
        [Fact]

        public void HoldIceShouldRemoveIce()
        {
            Tyrannotea t = new Tyrannotea();
            t.HoldIce();
            Assert.DoesNotContain<string>("Ice", t.Ingredients);
        }
        [Fact]

        public void AddLemonshouldaddLemon()
        {
            Tyrannotea t = new Tyrannotea();
            t.AddLemon();
            Assert.Contains<string>("Lemon", t.Ingredients);
            Assert.Equal<int>(3, t.Ingredients.Count);

        }
        [Fact]

        public void AddSeetShouldAddSweet()
        {
            Tyrannotea t = new Tyrannotea();
            t.AddSweet();
            Assert.Contains<string>("Sweet", t.Ingredients);
            Assert.Equal<int>(3, t.Ingredients.Count);


        }
        [Fact]

        public void ShouldUseCorrectCaloriesForSmallWithSweet()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Small;
            t.AddSweet();
            Assert.Equal<uint>(16, t.Calories);
        }
        [Fact]

        public void ShouldUseCorrectCaloriesForMeduimWithSweet()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            t.AddSweet();
            Assert.Equal<uint>(32, t.Calories);
        }
        [Fact]

        public void ShouldUseCorrectCaloriesForLargeWithSweet()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Large;
            t.AddSweet();
            Assert.Equal<uint>(64, t.Calories);
        }
        [Fact]

        public void ShouldUseCorrectCaloriesForLargeWithoutSweet()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Large;
            t.ReHoldSweet();
            Assert.Equal<uint>(32, t.Calories);
        }
        [Fact]

        public void ShouldUseCorrectCaloriesForMeduimWithOutSweet()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            t.ReHoldSweet();
            Assert.Equal<uint>(16, t.Calories);
        }
        [Fact]

        public void ShouldUseCorrectCaloriesForSmallWithoutSweet()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Small;
            t.ReHoldSweet();
            Assert.Equal<uint>(8, t.Calories);
        }

    }
}
