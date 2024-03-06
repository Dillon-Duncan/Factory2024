namespace Factory2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BurgerFactory burgerFactory = new BurgerFactory();

            Console.WriteLine("please enter your burger: ");
            String selectedBurger = Console.ReadLine(); 
            iBurger Burger = burgerFactory.getBurger(selectedBurger);

            Console.WriteLine("{0} bun and a {1} patty with {2}", 
                Burger.getBun(),Burger.getPatty(),Burger.getCondiments());

            Console.ReadLine();
        }
    }
}
