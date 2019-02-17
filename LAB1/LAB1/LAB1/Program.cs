using System;
using System.Collections.Generic;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            var option = Option.Instance.ChosenOption;
            var mealFactory = option.GetMealFactory();
            var drinkFactory = option.GetDrinkFactory();
            var menuFactory = option.GetMenuFactory();


            var meal = new List<Meal>();
            var drink = new List<Drink>();
            var menu = new List<IMenu>();

            meal.Add(mealFactory.CreateMeal("1", Combination.Pie));
            meal.Add(mealFactory.CreateMeal("2", Combination.Kebab));
            meal.Add(mealFactory.CreateMeal("3", Combination.Barbeque));

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
           
            Console.ReadKey();

        }
    }
}
