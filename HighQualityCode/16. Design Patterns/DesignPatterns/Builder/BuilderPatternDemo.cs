namespace Builder
{
    class BuilderPatternDemo
    {
        static void Main()
        {
            PizzaBuilder hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
            Cook cook = new Cook();
            cook.SetPizzaBuilder(hawaiianPizzaBuilder);
            cook.ConstructPizza();
            // create the product
            Pizza hawaiian = cook.GetPizza();

            PizzaBuilder spicyPizzaBuilder = new SpicyPizzaBuilder();
            cook.SetPizzaBuilder(spicyPizzaBuilder);
            cook.ConstructPizza();
            // create another product
            Pizza spicy = cook.GetPizza();
        }
    }
}