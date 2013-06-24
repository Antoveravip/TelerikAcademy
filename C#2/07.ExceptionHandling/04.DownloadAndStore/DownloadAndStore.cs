/* Lesson 7 - Exception Handling
 * Homework 4
 * 
 * Write a program that downloads a file from Internet 
 * (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and 
 * stores it the current directory. Find in Google how 
 * to download files in C#. Be sure to catch all exceptions
 * and to free any used resources in the finally block.
 */

using System;
using System.Net;

class DownloadAndStore
{
    static void Main()
    {
        //Test data
        string webAddress = "http://www.devbg.org/img/Logo-BASD.jpg";
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string fileName = "Logo-BASD.jpg";
        string fullPath = path + "\\" + fileName;
        /*
        Console.Write("Enter URL Path to download image : ");
        string webAddress = Console.ReadLine();
        Console.Write("Enter Filename : ");
        string fileName = Console.ReadLine();
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string fullPath = = path + "\\"+ fileName;
        */
        using (WebClient downFile = new WebClient())
        {
            try
            {
                downFile.DownloadFile(new Uri(webAddress), fullPath);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("You entered an empty address.");
            }
            catch (WebException we)
            {
                Console.WriteLine(we.Message);
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads.");
            }
        }
    }
}