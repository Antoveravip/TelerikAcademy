namespace AbstractFactory
{
    public class OSXButton : IButton
    { // Executes fourth if OS:OSX
        public void Paint()
        {
            System.Console.WriteLine("I'm an OSXButton");
        }
    }
}