namespace Factory2024
{
    internal class FishBurger : iBurger
    {
        public string getBun()
        {
            return "Toasted Wheat";
        }

        public string getCondiments()
        {
            return "Wasabi";
        }

        public string getPatty()
        {
            return "Fish";
        }
    }
}