using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public enum Name
    {
        Menu1, Menu2, Menu3
    }
    public interface IMenu
    {
       IMenu Clone();
    }

    class Menu : IMenu
    {
        public Name Name { get; }
        public Meal Meal { get; }
        public Drink Drink { get; }

        public Menu(Name name, Meal meal, Drink drink)
        {
            Name = name;
            Meal = meal;
            Drink = drink;
        }

        public  IMenu Clone()
        {
            return MemberwiseClone() as IMenu;
        }

        public override string ToString()
        {
            return string.Format("{0}\n MEAL:{1}\n DRINK:{2}\n",
                                Name, Meal, Drink);
        }
    }
}
