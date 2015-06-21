namespace RestaurantManager.Engine.Factories
{
    using Interfaces;
    using Interfaces.Engine;

    public class RestaurantFactory : IRestaurantFactory
    {
        public IRestaurant CreateRestaurant(string name, string location)
        {
           return new Restaurant(name, location);
        }
    }
}
