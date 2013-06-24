/* GUIFactory example -- */

using System;
using System.Configuration;

namespace AbstractFactory
{
    public class ApplicationRunner
    {
        static IGUIFactory CreateOsSpecificFactory()
        { 
            // Executes second
            // Contents of App.Config associated with this C# project
            //<?xml version="1.0" encoding="utf-8" ?>
            //<configuration>
            //  <appSettings>
            //    <!-- Uncomment either Win or OSX OS_TYPE to test -->
            //    <add key="OS_TYPE" value="Win" />
            //    <!-- <add key="OS_TYPE" value="OSX" /> -->
            //  </appSettings>
            //</configuration>
            string sysType = ConfigurationSettings.AppSettings["OS_TYPE"];
            if (sysType == "Win")
            {
                return new WinFactory();
            }
            else
            {
                return new OSXFactory();
            }
        }

        static void Main()
        { // Executes first
            new Application(CreateOsSpecificFactory());
            Console.ReadLine();
        }
    }
}