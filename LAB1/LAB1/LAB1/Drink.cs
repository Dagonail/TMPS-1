

namespace LAB1
{
    public enum Type
    {
        Hot, Cold
    }

    public enum Coffee
    {
        Americano, Expresso, Latte, None
    }

    public enum Tea
    {
        Black, Green, Red, None
    }

    public enum Special
    {
        Sugar, Milk, Water, Ice, None
    }

    public enum Juice
    {
        Tomato, Peach, Banana, Mix, Berries, None
    }

    public enum Soda
    {
        Cola, Sprite, Fanta, Pepsi, None
    }

    public class Drink
    {
        public string Name { get; }
        public Type Type { get; set; }
        public Coffee Coffee { get; set; }
        public Tea Tea { get; set; }
        public Juice Juice { get; set; }
        public Soda Soda { get; set; }
        public Special Special { get; set; }

        public Drink(string name) { Name = name; }

        public override string ToString()
        {
            return string.Format("\nName: {0}\nType: {1}\nCoffee: {2}\nTea: {3}\nJuice: {4}\n" +
                                "Soda: {5}\nSpecial: {6}\n",
                            Name, Type, Coffee, Tea, Juice, Soda, Special);
        }
    }

    public interface IDrinkBuilder
    {
        void BuildType(Type vtype);
        void BuildCoffee(Coffee vcoffee);
        void BuildTea(Tea vtea);
        void BuildJuice(Juice vjuice);
        void BuildSoda(Soda vsoda);
        void BuildSpecial(Special vspecial);
        Drink BuildDrink();
    }

    public class DrinkBuilder : IDrinkBuilder
    {
        private Drink drink;

        public DrinkBuilder(string name) => drink = new Drink(name);

        public void BuildType(Type vtype) => drink.Type = vtype;
        public void BuildCoffee(Coffee vcoffee) => drink.Coffee = vcoffee;
        public void BuildTea(Tea vtea) => drink.Tea = vtea;
        public void BuildJuice(Juice vjuice) => drink.Juice = vjuice;
        public void BuildSoda(Soda vsoda) => drink.Soda = vsoda;
        public void BuildSpecial(Special vspecial) => drink.Special = vspecial;
        public Drink BuildDrink() => drink;
    }

    public class ConcreteDrinkBuilder
    {
        public void Cold(IDrinkBuilder cold)
        {
            cold.BuildType(Type.Cold);
            cold.BuildCoffee(Coffee.None);
            cold.BuildTea(Tea.None);
            cold.BuildJuice(Juice.None);
            cold.BuildSoda(Soda.Cola);
            cold.BuildSpecial(Special.Ice);
        }
        public void Hot(IDrinkBuilder hot)
        {
            hot.BuildType(Type.Hot);
            hot.BuildCoffee(Coffee.None);
            hot.BuildTea(Tea.Black);
            hot.BuildJuice(Juice.None);
            hot.BuildSoda(Soda.None);
            hot.BuildSpecial(Special.Sugar);
        }

    }

}




