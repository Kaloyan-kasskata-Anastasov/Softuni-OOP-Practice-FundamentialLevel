namespace RestaurantManager
{
    using Interfaces;
    using Models;

    public abstract class Meal : Recipe, IMeal
    {
        protected Meal(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan)
            : base(name, price, calories, quantityPerServing, timeToPrepare)
        {
            this.IsVegan = isVegan;
            this.Unit = MetricUnit.Grams;
        }

        public bool IsVegan { get; set; }

        public void ToggleVegan()
        {
            this.IsVegan = !this.IsVegan;
        }

        public override string ToString()
        {
            string answer = this.IsVegan == true ? "VEGAN" : "";
            return string.Format("{0}{1}",
                answer,
                base.ToString());
        }
    }
}
