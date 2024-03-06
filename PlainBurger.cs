namespace Factory2024
{
    internal class PlainBurger : iBurger
    {
        public string getBun()
        {
            return "Wheat";
        }

        public string getCondiments()
        {
            return "Mayo";
        }

        public string getPatty()
        {
            return "Beef";
        }
    }
}