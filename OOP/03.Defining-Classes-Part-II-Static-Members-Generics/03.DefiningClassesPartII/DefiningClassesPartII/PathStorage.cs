using System;
using System.IO;

namespace DefiningClassesPartII
{
    public static class PathStorage
    {
        //To use file by choice of user must add "string file" as parameter not as variable
        public static void SavePath(string data)
        {
            string file = @"../PointStore.txt";
            try
            {
                StreamWriter dataWriter = new StreamWriter(file);
                using (dataWriter)
                {
                    dataWriter.Write(data);
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You does not have permission for write in this file: {0}", file);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File {0} not found", file);
            }
            catch (IOException)
            {
                Console.WriteLine("An input error occurred while opening the file: {0}", file);
            }
        }

        //To use file by choice of user must add "string file" as parameter not as variable
        public static string LoadPath()
        {
            string file = @"../PointStore.txt";
            string data = string.Empty;
            try
            {
                StreamReader dataReader = new StreamReader(file);
                using (dataReader)
                {
                    data = dataReader.ReadToEnd();
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You does not have the permission to read this file: {0}", file);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File {0} not found", file);
            }
            catch (IOException)
            {
                Console.WriteLine("An output error occurred while opening the file: {0}", file);
            }

            return data;
        }
    }
}