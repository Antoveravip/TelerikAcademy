namespace Builder
{
    // Director - responsible for managing the correct sequence of object creation.
    // Receives a Concrete Builder as a parameter and executes the necessary operations on it.
    class Cook
    {
        private PizzaBuilder _pizzaBuilder;

        public void SetPizzaBuilder(PizzaBuilder pb)
        {
            _pizzaBuilder = pb;
        }

        public Pizza GetPizza()
        {
            return _pizzaBuilder.GetPizza();
        }

        public void ConstructPizza()
        {
            _pizzaBuilder.CreateNewPizzaProduct();
            _pizzaBuilder.BuildDough();
            _pizzaBuilder.BuildSauce();
            _pizzaBuilder.BuildTopping();
        }
    }
}