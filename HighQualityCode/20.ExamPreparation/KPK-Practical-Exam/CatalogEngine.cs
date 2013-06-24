using System;
using System.Collections.Generic;
using System.Text;

namespace FreeContentCatalog
{
    public class CatalogEngine
    {
        public static void Main()
        {
            StringBuilder output = new StringBuilder();
            Catalog catalog = new Catalog();
            ICommandExecutor cmdExecutor = new CommandExecutor();

            var  commands = ReadInputCommands();
            foreach (ICommand cmd in commands)
            {
                cmdExecutor.ExecuteCommand(catalog, cmd, output);
            }

            Console.Write(output);
        }

        private static List<ICommand> ReadInputCommands()
        {
            List<ICommand> commands = new List<ICommand>();

            while(true)
            {
                string line = Console.ReadLine();
                if (line.Trim() == "End")
                {
                    break;
                }

                commands.Add(new Command(line));
            }

            return commands;
        }
    }
}