using System;

namespace LAB2.Structural
{
  //proxy starts
    public class ProxyOrder 
    {
        private readonly bool free;
        public ProxyOrder(bool next)
        {
            free = next;
        }
        public void PointOfSale(Meal meal)
        {
            if (free)
                meal.Order();
            else
                Console.WriteLine("Wait the kitcken....");
        }

    }
    //proxy finish
    // farcade starts
    public class FarcadeOrder
    {
        private readonly Meal pmeal;

        public FarcadeOrder(Meal meal)
        {
            pmeal = meal;
        }
      
        public void PointOfSale(bool free)
        { 
            ProxyOrder pr = new ProxyOrder(free);
            pr.PointOfSale(pmeal);
        }
    }
    //farcade finish
   



}
