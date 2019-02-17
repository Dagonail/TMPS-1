

namespace LAB1
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
                    hot.Hot(builder);
                    return builder.BuildDrink();
                case Type.Cold:
                    ConcreteDrinkBuilder cold = new ConcreteDrinkBuilder();
                    cold.Cold(builder);
                    return builder.BuildDrink();
            }
            return null;
        }
    }
}
