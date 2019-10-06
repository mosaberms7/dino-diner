using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;
using DinoDiner.Menu;
namespace MenuTest.Drinks
{
 public  class SodasaurusTest
    {
        [Fact]
        public void ShouldBeAbleToSetFlavorToCherry()
        {
            Sodasaurus ss = new Sodasaurus();
            ss.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, ss.Flavor);

        }
        public void ShouldBeAbleToSetFlavorToCola()
        {
            Sodasaurus ss = new Sodasaurus();
            ss.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, ss.Flavor);

        }
        public void ShouldBeAbleToSetFlavorToOrange()
        {
            Sodasaurus ss = new Sodasaurus();
            ss.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, ss.Flavor);

        }
        public void ShouldBeAbleToSetFlavorToVanillia()
        {
            Sodasaurus ss = new Sodasaurus();
            ss.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, ss.Flavor);

        }
        public void ShouldBeAbleToSetFlavorToChocolate()
        {
            Sodasaurus ss = new Sodasaurus();
            ss.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, ss.Flavor);

        }
        public void ShouldBeAbleToSetFlavorToRootBeer()
        {
            Sodasaurus ss = new Sodasaurus();
            ss.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, ss.Flavor);

        }
        public void ShouldBeAbleToSetFlavorToLime()
        {
            Sodasaurus ss = new Sodasaurus();
            ss.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, ss.Flavor);

        }
        public void ShouldBeAbleToSetFlavorTo()
        {
            Sodasaurus ss = new Sodasaurus();
            ss.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, ss.Flavor);

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
            Assert.True( ss.Ice);
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
            Sodasaurus soda = new Sodasaurus();
            Assert.Contains<string>("Water", soda.Ingredients);
            Assert.Contains<string>("Natural Flavors", soda.Ingredients);
            Assert.Contains<string>("Cane Sugar", soda.Ingredients);
            Assert.Contains<string>("Ice", soda.Ingredients);

            Assert.Equal<int>(4, soda.Ingredients.Count);
        }

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
        [Fact]

        public void ShouldHaveCorrectCaloriesAfterSettingMeduim()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<uint>(156, soda.Calories);
        }
        [Fact]

        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<uint>(208, soda.Calories);
        }
        [Fact]

        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Small;
            Assert.Equal<uint>(112, soda.Calories);
        }
        [Fact]

        public void HoldIceShouldRemoveIce()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
            Assert.DoesNotContain<string>("Ice", soda.Ingredients);
            Assert.Equal<int>(3, soda.Ingredients.Count);

        }
    }
}
