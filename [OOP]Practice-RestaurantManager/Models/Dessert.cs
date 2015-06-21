namespace RestaurantManager
{
    using Interfaces;

    public class Dessert : Meal, IDessert
    {
        public Dessert(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan)
            : base(name, price, calories, quantityPerServing, timeToPrepare, isVegan)
        {
            this.WithSugar = false;
        }

        public bool WithSugar { get; private set; }

        public void ToggleSugar()
        {
            this.WithSugar = !this.WithSugar;
        }

        public override string ToString()
        {
            string answer = this.WithSugar == true ? "SUGAR" : "";
            return string.Format("{0}{1}", answer, base.ToString());
        }
    }
}
