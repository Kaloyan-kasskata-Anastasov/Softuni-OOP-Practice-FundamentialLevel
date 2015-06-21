using System;
using RestaurantManager.Interfaces;
using RestaurantManager.Models;

namespace RestaurantManager
{
  

    public abstract class Recipe : IRecipe
    {
        private string name;
        private decimal price;
        private int calories;
        private int quantityPerServing;

        public Recipe(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare)
        {
            this.Name = name;
            this.Price = price;
            this.Calories = calories;
            this.QuantityPerServing = quantityPerServing;
            this.TimeToPrepare = timeToPrepare;
        }


        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(Messages.ArgumentCannotbeNullOrEmpty);
                }
                this.name = value;
                
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(Messages.CannotBeNegative);
                }
                this.price = value;
            }
        }

        public virtual int Calories
        {
            get { return this.calories; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(Messages.CannotBeNegative);
                }

                this.calories = value;
            }
        }

        public int QuantityPerServing
        {
            get { return this.quantityPerServing; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(Messages.CannotBeNegative);
                }
                this.quantityPerServing = value;
            }
        }

        public MetricUnit Unit { get; set; }

        public virtual int TimeToPrepare
        {
            get { return this.quantityPerServing; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(Messages.CannotBeNegative);
                }

                this.quantityPerServing = value;
            }
        }

        public override string ToString()
        {
            return string.Format("== {0} == ${1}\n" +
                                 "Per serving: {2} {3}, {4} kcal\n" +
                                 "Ready in {5} minutes",
                this.Name, 
                this.Price,
                this.QuantityPerServing,
                this.Unit,
                this.Calories,
                this.TimeToPrepare);
        }

        //==  <name> == $<price>
        //Per serving: <quantity> <unit>, <calories> kcal
        //Ready in <time_to_prepare> minutes
        //Carbonated: <yes / no>
    }
}
