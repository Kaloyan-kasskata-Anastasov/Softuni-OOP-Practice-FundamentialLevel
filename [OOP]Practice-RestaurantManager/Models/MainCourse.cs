namespace RestaurantManager
{
    using Interfaces;
    using Models;

    public class MainCourse : Meal, IMainCourse
    {
        public MainCourse(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan, string type)
            : base(name, price, calories, quantityPerServing, timeToPrepare, isVegan)
        {
            this.Type = ParseMainCourseType(type);
        }

        private static MainCourseType ParseMainCourseType(string type)
        {
            //this.Type = (MainCourseType)Enum.Parse(typeof(MainCourseType), type);
            switch (type)
            {
                case "Soup":
                    return MainCourseType.Soup;
                case "Entree":
                    return MainCourseType.Entree;
                case "Pasta":
                    return MainCourseType.Pasta;
                case "Side":
                    return MainCourseType.Side;
                case "Meat":
                    return MainCourseType.Meat;
                default:
                    return MainCourseType.Other;
            }
        }

        public MainCourseType Type { get; set; }
    }
}
