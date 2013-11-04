namespace AbstractFactory
{
    public class Application
    {
        public Application(IGUIFactory factory)
        {
            IButton button = factory.CreateButton();
            button.Paint();
        }
    }
}