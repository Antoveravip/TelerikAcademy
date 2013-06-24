namespace Builder
{
    // Concrete Builder - provides implementation for Builder; an object able to construct other objects.
    // Constructs and assembles parts to build the objects
    class SpicyPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            pizza.dough = "pan baked";
        }

        public override void BuildSauce()
        {
            pizza.sauce = "hot";
        }

        public override void BuildTopping()
        {
            pizza.topping = "pepperoni + salami";
        }
    }
}