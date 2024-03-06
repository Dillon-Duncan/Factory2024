namespace Factory2024
{
    internal class CheeseBurger : iBurger
    {
        public string getBun()
        {
            return "Wheat";
        }

        public string getCondiments()
        {
            return "Cheeese Sauce";
        }

        public string getPatty()
        {
            return "Beef";
        }
    }
}