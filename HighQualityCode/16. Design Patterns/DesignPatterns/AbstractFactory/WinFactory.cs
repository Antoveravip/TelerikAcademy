namespace AbstractFactory
{
    public class WinFactory : IGUIFactory
    { // Executes third if OS:WIN
        IButton IGUIFactory.CreateButton()
        {
            return new WinButton();
        }
    }
}