

namespace LAB2
{
     public interface IMenuFactory
        {
            IMenu CreateMenu(Name name, Meal meal, Drink drink);
        }

        class MenuFactory : IMenuFactory
        {
            public IMenu CreateMenu(Name name, Meal meal, Drink drink) => new Menu(name, meal, drink);
             
        }
    
}
