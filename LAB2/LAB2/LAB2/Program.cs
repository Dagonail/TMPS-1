using LAB2.Structural;
using System;
using System.Collections.Generic;

namespace LAB2
{
    class Program
    {

        public static Random rand = new Random();
        static void Main(string[] args)
        {
            var option = Option.Instance.ChosenOption;
            var mealFactory = option.GetMealFactory();
            var drinkFactory = option.GetDrinkFactory();
            var menuFactory = option.GetMenuFactory();


            var meal = new List<Meal>();
            var drink = new List<Drink>();
            var menu = new List<IMenu>();

            meal.Add(mealFactory.CreateMeal("1",  NewMeal.HappyMeal));
            meal.Add(mealFactory.CreateMeal("2",  NewMeal.MenuClassic));
            meal.Add(mealFactory.CreateMeal("3",  NewMeal.MenuPremium));
           

            drink.Add(drinkFactory.CreateDrink("1", Type.Cold));
            drink.Add(drinkFactory.CreateDrink("2", Type.Hot));

            var menu1 = menuFactory.CreateMenu(Name.Menu1, meal[0], drink[0]);
            var menu2 = menuFactory.CreateMenu(Name.Menu2 ,meal[1], drink[1]);
            var menu3 = menuFactory.CreateMenu(Name.Menu3, meal[2], drink[0]);

            menu.Add(menu1.Clone());
            menu.Add(menu2.Clone());
            menu.Add(menu3.Clone());
            

            Console.WriteLine("=======MEALS======\n");
            foreach (var x in meal)
            {
                Console.WriteLine(x.ToString());
            };
            Console.WriteLine("======DRINKS======\n");
            foreach (var x in drink)
            {
                Console.WriteLine(x.ToString());
            };
            Console.WriteLine("======MENUS======\n");
            foreach (var x in menu)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine(x.ToString());
            };

            Console.WriteLine("\nStructural Patterns:");
            var client1 = new ClientKid("Boy");
            var client2 = new ClientKid("Girl");
            var clientkid = new List<ClientKid>();
            clientkid.Add(client1);
            clientkid.Add(client2);
            foreach (ClientKid k in clientkid)
            {
                new FarcadeToy(k).PointofSale(rand.NextDouble() >= 0.5, rand.NextDouble() >= 0.5);
            }

            menu[0].MenuCl(new Client(new AdultwKid(new ClientKid("Boy"))));
            menu[0].MenuCl(new Client(new AdultwKid(new ClientKid("Girl"))));
            menu[1].MenuCl(new Client(new AdultClient()));
            menu[2].MenuCl(new Client(new AdultClientDecor()));

            Console.WriteLine("-----------------Check if MEAL available in the kitchen-----------------");
            foreach (Meal m in meal)
            {
                Console.Write(m.ToString());
                Console.WriteLine("...............................is ...");
                new FarcadeOrder(m).PointOfSale(rand.NextDouble() >= 0.5);
            }
        
           

            Console.ReadKey();

        }
    }
}
