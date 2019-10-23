using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest
{
    public class OrderTest
    {

        [Fact]
        public void OrderSubtotalCostShouldBeCorrect()
        {
            Order o = new Order();
            PterodactylWings p = new PterodactylWings();
            Fryceritops f = new Fryceritops();
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Large;

            o.Items.Add(p);
            o.Items.Add(s);
            o.Items.Add(f);


            Assert.Equal((p.Price + f.Price + s.Price), o.SubtotalCost);
        }

        [Fact]
        public void OrderSalesTaxCostShouldBeCorrect()
        {
            Order o = new Order();
            PterodactylWings p = new PterodactylWings();
            Fryceritops f = new Fryceritops();
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Large;

            o.Items.Add(p);
            o.Items.Add(s);
            o.Items.Add(f);
            Assert.Equal((p.Price + f.Price + s.Price)*o.SalesTaxRate, o.SalesTaxCost);
            
        }

        [Fact]
        public void OrderTotalCostShouldBeCorrect()
        {
            Order o = new Order();
            PterodactylWings p = new PterodactylWings();
            Fryceritops f = new Fryceritops();
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Large;

            o.Items.Add(p);
            o.Items.Add(s);
            o.Items.Add(f);
            Assert.Equal((p.Price + f.Price + s.Price)+ (p.Price + f.Price + s.Price)*o.SalesTaxRate, o.TotalCost);
            }
        [Fact]
        public void OrderSubtotalCostCantBecomeNegative()
        {
            Order o = new Order();
            PterodactylWings p = new PterodactylWings();
            p.Price = -10;
            o.Items.Add(p);

            Assert.True(o.SubtotalCost == 0);
        }

    }
}