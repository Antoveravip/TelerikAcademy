namespace AbstractFactory
{
    public class OSXFactory : IGUIFactory
    { // Executes third if OS:OSX
        IButton IGUIFactory.CreateButton()
        {
            return new OSXButton();
        }
    }
}