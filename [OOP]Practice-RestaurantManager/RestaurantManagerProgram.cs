namespace RestaurantManager
{
    using System;
    using System.Globalization;
    using System.Threading;
    using Engine;

    public class RestaurantManagementProgram
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            RestaurantManagerEngine.Instance.Start();

            Drink ajran = new Drink("ajran", 1m, 87, 300, 2, false);
            Salad ShopskaSalad = new Salad("ShopskaSalad", 5.60m, 8700, 300, 10, false);
            Restaurant priPesho = new Restaurant("priPesho", "asdasd21323 Sofia");

            Console.WriteLine(priPesho.PrintMenu());
        }
    }
}