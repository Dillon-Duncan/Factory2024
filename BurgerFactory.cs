using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory2024
{
    internal class BurgerFactory
    {

        public iBurger returnInstance;
        public iBurger getBurger(String burgerType)
        {
            if(burgerType.ToLower().Equals("chicken"))
            {
                returnInstance = new ChickenBurger();
            }
            else if (burgerType.ToLower().Equals("cheese"))
            {
                returnInstance = new CheeseBurger();
            }
            else if (burgerType.ToLower().Equals("fish"))
            {
                returnInstance = new FishBurger();
            }
            else
            {
                returnInstance = new PlainBurger();
            }

            return returnInstance;
        }

    }
}
