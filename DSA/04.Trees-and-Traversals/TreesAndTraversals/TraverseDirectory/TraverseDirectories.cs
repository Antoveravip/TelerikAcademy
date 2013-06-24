/* Lesson 4 - Trees and Traversals
 * Homework 2
 * 
 * Write a program to traverse the directory C:\WINDOWS and all 
 * its subdirectories recursively and to display all files
 * matching the mask *.exe. Use the class System.IO.Directory.
 */

namespace TraverseDirectory
{
    using System;
    using System.IO;

    public static class TraverseDirectories
    {
        private static int accessdenied = 0;

        public static void Main()
        {
            string mainFolder = "C:\\Windows";

            DirectoryTraverse(mainFolder);
        }

        public static void DirectoryTraverse(string mainFolder)
        {
            string[] subDirectories = null;

            try
            {
                subDirectories = Directory.GetDirectories(mainFolder);
            }
            catch (UnauthorizedAccessException)
            {
                accessdenied++;
                Console.WriteLine("Access Denied: {0}", accessdenied);
                return;
            }

            PrintExecutables(mainFolder);

            foreach (var subDir in subDirectories)
            {
                DirectoryTraverse(subDir);
            }
        }

        private static void PrintExecutables(string path)
        {
            string[] files = null;
            files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                if (file.EndsWith(".exe"))
                {
                    Console.WriteLine(file);
                }
            }
        }
    }
}