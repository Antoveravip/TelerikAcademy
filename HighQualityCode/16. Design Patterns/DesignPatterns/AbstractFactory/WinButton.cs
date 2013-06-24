namespace AbstractFactory
{
    public class WinButton : IButton
    { // Executes fourth if OS:WIN
        public void Paint()
        {
            System.Console.WriteLine("I'm a WinButton");
        }
    }
}