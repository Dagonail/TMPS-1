

namespace LAB2
{
    public interface IDrinkFactory
    {
       Drink CreateDrink(string name, Type type);
    }
    public class DrinkFactory : IDrinkFactory
    {
     
        public Drink CreateDrink(string name, Type type)
        {
            IDrinkBuilder builder = new DrinkBuilder(name);

            switch (type)
            {
                case Type.Hot:
                    ConcreteDrinkBuilder hot = new ConcreteDrinkBuilder();
                    hot.HotDrink(builder);
                    return builder.BuildDrink();
                    
                   
                case Type.Cold:
                    ConcreteDrinkBuilder cold = new ConcreteDrinkBuilder();
                    cold.ColdDrink(builder);
                    return builder.BuildDrink();
            }
            return null;
        }
    }
}
