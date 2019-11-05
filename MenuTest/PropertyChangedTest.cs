using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class PropertyChangedTest
    {
        [Fact]
        public void BrontowurstPrpertyChangesShouldBeCorrect()
        {
            Brontowurst b = new Brontowurst();
            Assert.PropertyChanged(b, "Special", () => b.HoldBun());
            Assert.PropertyChanged(b, "Special", () => b.HoldOnion());
            Assert.PropertyChanged(b, "Special", () => b.HoldPeppers());
        }
        [Fact]
        public void DinoPrpertyChangesShouldbeCorrect()
        {
            DinoNuggets d = new DinoNuggets();
            Assert.PropertyChanged(d, "Special", () => d.AddNugget());
            Assert.PropertyChanged(d, "Price", () => d.AddNugget());
            Assert.PropertyChanged(d, "Calories", () => d.AddNugget());
        }

        [Fact]
        public void PrehistoricPBJPropertyChangesShouldbecorrect()
        {
            PrehistoricPBJ p = new PrehistoricPBJ();
            Assert.PropertyChanged(p, "Special", () => p.HoldJelly());
            Assert.PropertyChanged(p, "Special", () => p.HoldPeanutButter());
        }
        [Fact]
        public void PterodactylWingsPropertyChangesShouldWorkProperly() { /*Nothing*/}


        [Fact]
        public void SteakosaurusBurgerPropertyChangesShouldBecorrect()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            Assert.PropertyChanged(s, "Special", () => s.HoldBun());
            Assert.PropertyChanged(s, "Special", () => s.HoldKetchup());
            Assert.PropertyChanged(s, "Special", () => s.HoldMustard());
            Assert.PropertyChanged(s, "Special", () => s.HoldPickle());
        }
        [Fact]
        public void TRexKingBurgerPropertyChangesShouldBeCorrect()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.PropertyChanged(t, "Special", () => t.HoldTomato());
            Assert.PropertyChanged(t, "Special", () => t.HoldKetchup());
            Assert.PropertyChanged(t, "Special", () => t.HoldMayo());
            Assert.PropertyChanged(t, "Special", () => t.HoldBun());
            Assert.PropertyChanged(t, "Special", () => t.HoldLettuce());
            Assert.PropertyChanged(t, "Special", () => t.HoldMustard());
            Assert.PropertyChanged(t, "Special", () => t.HoldOnion());
            Assert.PropertyChanged(t, "Special", () => t.HoldPickle());
        }
        [Fact]
        public void VelociWrapPropertyChangesShouldBeCorrect()
        {
            VelociWrap v = new VelociWrap();
            Assert.PropertyChanged(v, "Special", () => v.HoldDressing());
            Assert.PropertyChanged(v, "Special", () => v.HoldLettuce());
            Assert.PropertyChanged(v, "Special", () => v.HoldCheese());

        }
        [Fact]
        public void FryceritopsPropertyChangesShouldBeCorrect()
        {
            Fryceritops f = new Fryceritops();
            Assert.PropertyChanged(f, "Description", () => f.Size = Size.Large);
            Assert.PropertyChanged(f, "Price", () => f.Size = Size.Large);
            Assert.PropertyChanged(f, "Size", () => f.Size = Size.Large);
            Assert.PropertyChanged(f, "Calories", () => f.Size = Size.Large);
        }
        [Fact]
        public void MeteorMacAndCheesePropertyChangesShouldBeCorrect()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            Assert.PropertyChanged(m, "Description", () => m.Size = Size.Large);
            Assert.PropertyChanged(m, "Price", () => m.Size = Size.Large);
            Assert.PropertyChanged(m, "Size", () => m.Size = Size.Large);
            Assert.PropertyChanged(m, "Calories", () => m.Size = Size.Large);
        }
        [Fact]
        public void MezzorellaSticksPropertyChangesShouldBeCorrect()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            Assert.PropertyChanged(m, "Description", () => m.Size = Size.Large);
            Assert.PropertyChanged(m, "Price", () => m.Size = Size.Large);
            Assert.PropertyChanged(m, "Size", () => m.Size = Size.Large);
            Assert.PropertyChanged(m, "Calories", () => m.Size = Size.Large);
        }

        [Fact]
        public void TriceritotsPropertyChangesShouldBeCorrect()
        {
            Triceritots t = new Triceritots();
            Assert.PropertyChanged(t, "Description", () => t.Size = Size.Large);
            Assert.PropertyChanged(t, "Calories", () => t.Size = Size.Large);
            Assert.PropertyChanged(t, "Size", () => t.Size = Size.Large);
            Assert.PropertyChanged(t, "Price", () => t.Size = Size.Large);
        }
        /******************************************/
        [Fact]
        public void JurassicJavaPropertyChangesShouldBeCorrect()
        {
            JurassicJava j = new JurassicJava();
            Assert.PropertyChanged(j, "Size", () => j.Size = Size.Large);
            Assert.PropertyChanged(j, "Price", () => j.Size = Size.Large);
            Assert.PropertyChanged(j, "Calories", () => j.Size = Size.Large);
            Assert.PropertyChanged(j, "Description", () => j.Size = Size.Large);

            Assert.PropertyChanged(j, "Decaf", () => j.Decaf = true);
            Assert.PropertyChanged(j, "Description", () => j.Decaf = true);

            Assert.PropertyChanged(j, "Ice", () => j.Ice = true);
            Assert.PropertyChanged(j, "Special", () => j.Ice = true);
            //Assert.PropertyChanged(j, "Ice", () => j.AddIce());
            //Assert.PropertyChanged(j, "Special", () => j.AddIce());
        }

        [Fact]
        public void SodasaurusPropertyChangesShouldBeCorrect()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.PropertyChanged(s, "Size", () => s.Size = Size.Large);
            Assert.PropertyChanged(s, "Price", () => s.Size = Size.Large);
            Assert.PropertyChanged(s, "Calories", () => s.Size = Size.Large);
            Assert.PropertyChanged(s, "Description", () => s.Size = Size.Large);

            Assert.PropertyChanged(s, "Description", () => s.Flavor = SodasaurusFlavor.Cherry);
            Assert.PropertyChanged(s, "Flavor", () => s.Flavor = SodasaurusFlavor.Cherry);

            Assert.PropertyChanged(s, "Ice", () => s.Ice = false);
            Assert.PropertyChanged(s, "Special", () => s.Ice = false);
        }

        [Fact]
        public void TyrannoteaPropertyChangesShouldBeCorrect()
        {
            Tyrannotea tt = new Tyrannotea();

            Assert.PropertyChanged(tt, "Description", () => tt.Sweet = true);
            Assert.PropertyChanged(tt, "Calories", () => tt.Sweet = false);
            Assert.PropertyChanged(tt, "Sweet", () => tt.Sweet = true);

            Assert.PropertyChanged(tt, "Size", () => tt.Size = Size.Large);
            Assert.PropertyChanged(tt, "Price", () => tt.Size = Size.Large);
            Assert.PropertyChanged(tt, "Calories", () => tt.Size = Size.Large);
            Assert.PropertyChanged(tt, "Description", () => tt.Size = Size.Large);

          
            Assert.PropertyChanged(tt, "Lemon", () => tt.Lemon = true);
            Assert.PropertyChanged(tt, "Special", () => tt.Lemon = true);

            Assert.PropertyChanged(tt, "Ice", () => tt.Ice = true);
            Assert.PropertyChanged(tt, "Special", () => tt.Ice = true);
        }
        [Fact]
        public void WaterPropertyChangesShouldBeCorrect()
        {
            Water w = new Water();


            Assert.PropertyChanged(w, "Description", () => w.Size = Size.Large);
            Assert.PropertyChanged(w, "Size", () => w.Size = Size.Large);
            Assert.PropertyChanged(w, "Special", () => w.Lemon = true);
            Assert.PropertyChanged(w, "Lemon", () => w.Lemon = true);

        }
        /************************************************/
        [Fact]
        public void CretaceousComboPropertyChangesShouldBeCorrect()
        {
            CretaceousCombo c = new CretaceousCombo(new TRexKingBurger());
            Assert.PropertyChanged(c, "Special", () => c.Side = new MezzorellaSticks());
            Assert.PropertyChanged(c, "Side", () => c.Side = new MezzorellaSticks());

            Assert.PropertyChanged(c, "Special", () => c.Entree = new PrehistoricPBJ());
            Assert.PropertyChanged(c, "Entree", () => c.Entree = new PrehistoricPBJ());

            
            Assert.PropertyChanged(c, "Special", () =>c.Drink = new Water());
            Assert.PropertyChanged(c, "Drink", () => c.Drink = new Water());

            Assert.PropertyChanged(c, "Toy", () => c.ChangeToy("Another Toy"));
        }



    }
}
