
using LAB2.Structural;

namespace LAB2
{
  
        public interface IMealFactory
        {
                
                 Meal CreateMeal(string name, NewMeal nm);
            
        }

        public class MealFactory : IMealFactory
        {
            public Meal CreateMeal(string name, NewMeal nm)
            {
            IMealBuilder builder = new MealBuilder(name);
            switch (nm)
            {
                    case NewMeal.HappyMeal:
                        ConcreteMealBuilder happy = new ConcreteMealBuilder();
                        happy.HappyMeal(builder);
                        return builder.BuildMeal();
                    case NewMeal.MenuClassic:
                        ConcreteMealBuilder classic = new ConcreteMealBuilder();
                        classic.MeniuClasic(builder);
                        return builder.BuildMeal();
                    case NewMeal.MenuPremium:
                        ConcreteMealBuilder premium= new ConcreteMealBuilder();
                        premium.MeniuClasic(builder);
                        return builder.BuildMeal();

            }
            return null;
            }
        }
    
}
