namespace RestaurantManager
{
    using System;
    using Interfaces;
    using Models;

    public class Drink : Recipe, IDrink
    {
        public Drink(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isCarbonated)
            : base(name, price, calories, quantityPerServing, timeToPrepare)
        {
            this.IsCarbonated = isCarbonated;
            this.Unit = MetricUnit.Milliliters;
        }

        public override int Calories
        {
            set
            {
                //•	The calories in a drink must not be greater than 100.
                if (value >= 100)
                {
                    throw new ArgumentException(Messages.DrinkIsBiggerThanValue);
                }

                base.Calories = value;
            }
        }
        //•	The time to prepare a drink must not be greater than 20 minutes.
        public override int TimeToPrepare
        {
            set
            {
                if (value >= 20)
                {
                    throw new ArgumentException(Messages.TimeToprepareGreaterThanValue);
                }
                base.TimeToPrepare = value;
            }
        }

        public bool IsCarbonated { get; set; }

        public override string ToString()
        {
            var answer = this.IsCarbonated == true ? "yes" :"no";
            return string.Format("{0}\nCarbonated:{1}", 
                base.ToString(),
                answer);
        }
    }
}
