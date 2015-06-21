namespace RestaurantManager
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Interfaces;

    public class Restaurant : IRestaurant
    {
        public Restaurant(string name, string location)
        {
            this.Name = name;
            this.Location = location;
            this.Recipes = new List<IRecipe>();
        }

        public string Name { get; set; }
        public string Location { get; set; }
        public IList<IRecipe> Recipes { get; private set; }

        public void AddRecipe(IRecipe recipe)
        {
            this.Recipes.Add(recipe);
        }

        public void RemoveRecipe(IRecipe recipe)
        {
            this.Recipes.Remove(recipe);
        }

        public string PrintMenu()
        {
            StringBuilder result = new StringBuilder();

            //~~~~~ DRINKS ~~~~~
            //~~~~~ SALADS ~~~~~
            //~~~~~ MAIN COURSES ~~~~~
            //~~~~~ DESSERTS ~~~~~
            var drinks = this.Recipes
                .Where(r => r is IDrink)
                .OrderBy(d => d.Name);
            var salads = this.Recipes
                .Where(r => r is ISalad)
                .OrderBy(s => s.Name);
            var mainCourses = this.Recipes
                .Where(r => r is IMainCourse)
                .OrderBy(mc => mc.Name);
            var dessert = this.Recipes
                .Where(r => r is IDessert)
                .OrderBy(d => d.Name);

            if (drinks.Any())
            {
                foreach (var drink in drinks)
                {
                    result.AppendLine(drink.ToString());
                }
            }

            return result.ToString();
        }
    }
}
