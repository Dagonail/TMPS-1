

using System;

namespace LAB2
{


        public enum Sweets
        {
            Icecream, Croissant, Cookie, Muffin, None
        }

        public enum Burger
        {
            McChicke, BigMac, McPuisor, Cheeseburger, Hamburger, None
        }

        public enum Wraps
        {
           ChickenMcWrap, BeefMcWrap, Hashwrap, None
        }

        public enum Potatoe
        {
            FrenchFries, Wedges, None
        }

        public enum Salads
        {
            Caesar, Greek, Primavera, None
        }
        public enum Portion
        {
           Yes, No
        }
        public enum NewMeal
        {
            HappyMeal, MenuClassic, MenuPremium
        }
    public  class Meal
        {
            public string Name { get; }
            public NewMeal NewMeal { get; set; }
            public Burger Burger { get; set; }
            public Wraps Wraps { get; set; }
            public Potatoe Potatoe { get; set; }
            public Salads Salads{ get; set; }
            public Sweets Sweets { get; set; }
            public Portion Portion { get; set; }

            public Meal(string name) { Name = name; }
            
            public override string ToString()
            {
                return string.Format("\nName: {0}\nBurger: {1}\nPotatoes:{2}\nWraps: {3}\nSalads: {4}\n" +
                                    "Sweets: {5}\nToy: {6}\n",
                                Name, Burger, Potatoe,  Wraps, Salads, Sweets, Portion);
            }
            public void Order()
            {
                Console.WriteLine("Available...");
            }
    }

    public interface IMealBuilder
    {
        void BuildNew(NewMeal nm);
        void BuildBurger(Burger bg);
        void BuildPotatoe(Potatoe pt);
        void BuildWraps(Wraps wr);
        void BuildSalad(Salads sl);
        void BuildSweets(Sweets sw);
        void BuildPortion(Portion pr);

        Meal BuildMeal();

    }
    public class MealBuilder : IMealBuilder
    {
        private Meal meal;
        public MealBuilder(string name) => meal = new Meal(name);

        public void BuildNew(NewMeal nm) => meal.NewMeal = nm;
        public void BuildBurger(Burger bg) => meal.Burger = bg;
        public void BuildPotatoe(Potatoe pt) => meal.Potatoe = pt;
        public void BuildWraps(Wraps wr) => meal.Wraps = wr;
        public void BuildSalad(Salads sl) => meal.Salads = sl;
        public void BuildSweets(Sweets sw) => meal.Sweets = sw;
        public void BuildPortion(Portion pr) => meal.Portion = pr;
        public Meal BuildMeal() => meal;


    }

    public class ConcreteMealBuilder
    {
        public void HappyMeal(IMealBuilder happym)
        {
            happym.BuildNew(NewMeal.HappyMeal);
            happym.BuildBurger(Burger.Cheeseburger);
            happym.BuildPotatoe(Potatoe.FrenchFries);
            happym.BuildWraps(Wraps.None);
            happym.BuildSalad(Salads.None);
            happym.BuildSweets(Sweets.None);
            happym.BuildPortion(Portion.Yes);

        }
        public void MeniuClasic(IMealBuilder classic)
        {
            classic.BuildNew(NewMeal.MenuClassic);
            classic.BuildBurger(Burger.BigMac);
            classic.BuildPotatoe(Potatoe.Wedges);
            classic.BuildWraps(Wraps.None);
            classic.BuildSalad(Salads.Greek);
            classic.BuildSweets(Sweets.None);
            classic.BuildPortion(Portion.No);
        }
        public void MeniuPremium(IMealBuilder premium)
        {
            premium.BuildNew(NewMeal.MenuPremium);
            premium.BuildBurger(Burger.Hamburger);
            premium.BuildPotatoe(Potatoe.FrenchFries);
            premium.BuildWraps(Wraps.Hashwrap);
            premium.BuildSalad(Salads.Caesar);
            premium.BuildSweets(Sweets.Croissant);
            premium.BuildPortion(Portion.No);
        }

    }
   

   

}




