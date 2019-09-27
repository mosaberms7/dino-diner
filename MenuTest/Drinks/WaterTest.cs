using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using Xunit;

namespace MenuTest.Drinks
{
    class WaterTest
    {
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water w = new Water();
            Assert.Equal(0.11, w.Price);
        }
        public void ShouldHaveTheDefaultCalories()
        {
            Water w = new Water();
            Assert.Equal<uint>(0,w.Calories);
        }

        public void ShouldHaveTheDefaultSize()
        {
            Water w=new Water();
            Assert.Equal(Size.Small, w.Size);
        }
        public void ShouldHaveDefaultIce()
        {
            Water w = new Water();
            Assert.True(w.Ice);
        }

        public void ShouldHaveDefaultLemon()
        {
            Water w = new Water();
            Assert.False(w.Lemon);

        }
    }
}
