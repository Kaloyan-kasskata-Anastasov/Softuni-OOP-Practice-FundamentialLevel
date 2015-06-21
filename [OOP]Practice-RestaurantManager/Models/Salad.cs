namespace RestaurantManager
{
    using Interfaces;

    public class Salad : Meal, ISalad
    {
        private const bool DefaultSaladVegan = true;

        public Salad(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool containsPasta)
            : base(name, price, calories, quantityPerServing, timeToPrepare, DefaultSaladVegan)
        {
            this.ContainsPasta = containsPasta;
        }

        public bool ContainsPasta { get; set; }

        public override string ToString()
        {
            string answer = this.ContainsPasta == true ? "yes" : "no";
            return string.Format("{0}{1}", answer, base.ToString());
        }
    }
}
