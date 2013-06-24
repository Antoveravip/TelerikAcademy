using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeContentCatalog
{
    public class CommandExecutor : ICommandExecutor
    {
        public void ExecuteCommand(ICatalog catalog, ICommand cmd, StringBuilder output)
        {
            switch (cmd.Type)
            {
                case CommandType.AddBook:
                    {
                        catalog.Add(new ContentItem(ContentItemType.Book, cmd.Parameters));
                        output.AppendLine("Books Added");
                        break;
                    }

                case CommandType.AddMovie:
                    {
                        catalog.Add(new ContentItem(ContentItemType.Movie, cmd.Parameters));
                        output.AppendLine("Movie added");
                        break;
                    }

                case CommandType.AddSong:
                    {
                        catalog.Add(new ContentItem(ContentItemType.Song, cmd.Parameters));
                        output.AppendLine("Song added");
                        break;
                    }

                case CommandType.AddApplication:
                    {
                        catalog.Add(new ContentItem(ContentItemType.Application, cmd.Parameters));
                        output.AppendLine("Application added");
                        break;
                    }

                case CommandType.Update:
                    {
                        ProcessUpdateCommand(catalog, cmd, output);
                        break;
                    }

                case CommandType.Find:
                    {
                        ProcessFindCommand(catalog, cmd, output);
                        break;
                    }

                default:
                    {
                        throw new InvalidOperationException("Unknown command!");
                    }
            }
        }

        private static void ProcessUpdateCommand(ICatalog catalog, ICommand cmd, StringBuilder output)
        {
            if (cmd.Parameters.Length != 2)
            {
                throw new ArgumentException("Invalid number of parameters!");
            }
            int itemsUpdated = catalog.UpdateContent(cmd.Parameters[0], cmd.Parameters[1]);
            string updateResult = String.Format("{0} items updated", itemsUpdated);
            output.AppendLine(updateResult);
        }

        private static void ProcessFindCommand(ICatalog catalog, ICommand cmd, StringBuilder output)
        {
            if (cmd.Parameters.Length != 2)
            {
                throw new ArgumentException("Invalid number of parameters!");
            }

            int numberOfElementsToList = int.Parse(cmd.Parameters[1]);
            IEnumerable<IContentItem> foundContent = catalog.GetListContent(cmd.Parameters[0], numberOfElementsToList);

            if (foundContent.Count() == 0)
            {
                output.AppendLine("No items found");
            }
            else
            {
                foreach (IContentItem content in foundContent)
                {
                    output.AppendLine(content.TextRepresentation);
                }
            }
        }
    }
}