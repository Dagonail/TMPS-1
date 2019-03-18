

namespace LAB2
{
    public enum Type
    {
        Hot, Cold
    }

    public enum Others
    {
        OrangeJuice, Water, None
    }

    public enum Hot
    {
        Coffee, Tea, Cappucino, None
    }

    public enum Cold
    {
        CocaCola, Fanta,Sprite, Lipton, None
    }

    public enum Special
    {
       Ice, Milk, Sugar, None
    }


    public class Drink
    {
        public string Name { get; }
        public Type Type { get; set; }
        public Hot Hot { get; set; }
        public Cold Cold { get; set; }
        public Others Others { get; set; }
        public Special Special { get; set; }

        public Drink(string name) { Name = name; }

        public override string ToString()
        {
            return string.Format("\nName: {0}\nType: {1}\nHot: {2}\nCold: {3}\nOthers: {4}\n" +
                                "Special: {5}\n",
                            Name,Type, Hot, Cold, Others, Special);
        }


    }

    public partial interface IDrinkBuilder
    {
        void BuildType(Type vtype);
        void BuildHot(Hot ht);
        void BuildCold(Cold cl);
        void BuildOthers(Others ot);
        void BuildSpecial(Special vspecial);
        Drink BuildDrink();
    }

    public partial class DrinkBuilder : IDrinkBuilder
    {
        private Drink drink;

        public DrinkBuilder(string name) => drink = new Drink(name);

        public void BuildType(Type vtype) => drink.Type = vtype;
        public void BuildHot(Hot ht) => drink.Hot = ht;
        public void BuildCold(Cold cl) => drink.Cold = cl;
        public void BuildOthers(Others ot) => drink.Others = ot;
        public void BuildSpecial(Special vspecial) => drink.Special = vspecial;
        public Drink BuildDrink() => drink;
    }

    public class ConcreteDrinkBuilder
    {
        public void ColdDrink(IDrinkBuilder cold)
        {

            cold.BuildType(Type.Cold);
            cold.BuildCold(Cold.Fanta);
            cold.BuildHot(Hot.None);
            cold.BuildOthers(Others.None);
            cold.BuildSpecial(Special.Ice);

    }
        public void HotDrink(IDrinkBuilder hot)
        {
            hot.BuildType(Type.Hot);
            hot.BuildCold(Cold.None);
            hot.BuildHot(Hot.Coffee);
            hot.BuildOthers(Others.None);
            hot.BuildSpecial(Special.Sugar);
        }

    }

}




