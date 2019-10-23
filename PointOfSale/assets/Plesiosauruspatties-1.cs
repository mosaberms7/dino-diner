using System;
using System.Collections.Generic;
using System.Text;
namespace DDExample
{
    class Plesiosauruspatties : Entree
    {
        private bool mayo = true;
        private bool bun = true;
        private List<string> ingredients;
        public override double Price
        {
            get
            {
                return 5.50;
            }
        }
        public override uint Calories { get; } = 487;

      
        public Plesiosauruspatties()
        {

            bun = true;
            mayo = true;
            Price = 5.50;
            Calories = 487;
            ingredients = new List<string>();
            ingredients.Add("Fish Patty");
            if (bun) ingredients.Add("WHEAte Whole Bun");
            if (mayo) ingredients.Add("Mayo");

        }
        public void HoldBun()
        {
            bun = false;
            Ingredients.Remove("WHEAte Whole Bun");

        }
        public void HoldMayo()
        {
            mayo = false;
            Ingredients.Remove("Mayo");
        }
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>(ingredients);
            }
        }

    }
}
