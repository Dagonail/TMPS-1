
namespace LAB2
{
  
        public interface IChosen
        {
            IMealFactory GetMealFactory();
            IMenuFactory GetMenuFactory();
            IDrinkFactory GetDrinkFactory();
        }

        public class ChosenOption : IChosen
        {
            public IMealFactory GetMealFactory() => new MealFactory();

            public IDrinkFactory GetDrinkFactory() => new DrinkFactory();

            public IMenuFactory GetMenuFactory() => new MenuFactory();

            
         }

    
}
