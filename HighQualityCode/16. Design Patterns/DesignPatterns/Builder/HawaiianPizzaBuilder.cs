namespace Builder
{
    // Concrete Builder - provides implementation for Builder; an object able to construct other objects.
    // Constructs and assembles parts to build the objects
    class HawaiianPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            pizza.dough = "cross";
        }

        public override void BuildSauce()
        {
            pizza.sauce = "mild";
        }

        public override void BuildTopping()
        {
            pizza.topping = "ham+pineapple";
        }
    }
}