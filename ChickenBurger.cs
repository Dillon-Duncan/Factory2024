namespace Factory2024
{
    internal class ChickenBurger : iBurger
    {
        public string getBun()
        {
            return "Bagel";
        }

        public string getCondiments()
        {
            return "Sweet Chillie";
        }

        public string getPatty()
        {
            return "Chicken";
        }
    }
}