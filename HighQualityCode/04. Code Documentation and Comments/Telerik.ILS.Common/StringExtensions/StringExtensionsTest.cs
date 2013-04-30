//-----------------------------------------------------------------------
// <copyright file="StringExtensionsTest.cs" company="Telerik Academy">
//  Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>
// <author>For academy reason - crypted info</author>
//-----------------------------------------------------------------------
namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Test the methods from <see cref="Telerik.ILS.Common.StringExtensions"/> class.
    /// </summary>
    public static class StringExtensionsTest
    {
        /// <summary>
        /// Test all methods from <see cref="Telerik.ILS.Common.StringExtensions"/> class.
        /// </summary>
        public static void Main()
        {
            // Test ToMD5Hash() method
            string value = "Green green wordl. Happy Spring";
            Console.WriteLine("Test ToMD5Hash() method" + Environment.NewLine + new string('-', 50));
            Console.WriteLine("Input data: {0}", value);
            Console.WriteLine("Output data: {0}", value.ToMd5Hash() + Environment.NewLine + new string('-', 50));

            // Test ToBoolean() method
            value = "да";
            Console.WriteLine("Test ToBoolean() method" + Environment.NewLine + new string('-', 50));
            Console.WriteLine("Input data: {0}", value);
            Console.WriteLine("Output data: {0}", value.ToBoolean() + Environment.NewLine + new string('-', 50));

            // Test ToShort() method
            value = "-32768";
            Console.WriteLine("Test ToShort() method" + Environment.NewLine + new string('-', 50));
            Console.WriteLine("Input data: {0}", value);
            Console.WriteLine("Output data: {0}", value.ToShort() + Environment.NewLine + new string('-', 50));

            // Test ToInteger() method
            value = "1234567890";
            Console.WriteLine("Test ToInteger() method" + Environment.NewLine + new string('-', 50));
            Console.WriteLine("Input data: {0}", value);
            Console.WriteLine("Output data: {0}", value.ToInteger() + Environment.NewLine + new string('-', 50));

            // Test ToLong() method
            value = "9223372036854775807";
            Console.WriteLine("Test ToLong() method" + Environment.NewLine + new string('-', 50));
            Console.WriteLine("Input data: {0}", value);
            Console.WriteLine("Output data: {0}", value.ToLong() + Environment.NewLine + new string('-', 50));

            // Test ToDateTime() method
            value = "2012/01/04 17:51:50";
            Console.WriteLine("Test ToDateTime() method" + Environment.NewLine + new string('-', 50));
            Console.WriteLine("Input data: {0}", value);
            Console.WriteLine("Output data: {0}", value.ToDateTime() + Environment.NewLine + new string('-', 50));

            // Test CapitalizeFirstLetter() method
            value = "bAbA tOnka";
            Console.WriteLine("Test CapitalizeFirstLetter() method" + Environment.NewLine + new string('-', 50));
            Console.WriteLine("Input data: {0}", value);
            Console.WriteLine("Output data: {0}", value.CapitalizeFirstLetter() + Environment.NewLine + new string('-', 50));

            // Test GetStringBetween() method
            value = "Get the horse into the river";
            Console.WriteLine("Test GetStringBetween() method" + Environment.NewLine + new string('-', 50));
            Console.WriteLine("Input data: {0}", value);
            Console.WriteLine("Output data: {0}", value.GetStringBetween("horse", "river", 1) + Environment.NewLine + new string('-', 50));

            // Test ConvertCyrillicToLatinLetters() method
            value = "А ние двамата с Боби пием кафе!";
            Console.WriteLine("Test ConvertCyrillicToLatinLetters() method" + Environment.NewLine + new string('-', 50));
            Console.WriteLine("Input data: {0}", value);
            Console.WriteLine("Output data: {0}", value.ConvertCyrillicToLatinLetters() + Environment.NewLine + new string('-', 50));

            // Test ConvertLatinToCyrillicKeyboard() method
            value = "Sometimes win, sometimes lose. Just keep playing!";
            Console.WriteLine("Test ConvertLatinToCyrillicKeyboard() method" + Environment.NewLine + new string('-', 50));
            Console.WriteLine("Input data: {0}", value);
            Console.WriteLine("Output data: {0}", value.ConvertLatinToCyrillicKeyboard() + Environment.NewLine + new string('-', 50));

            // Test ToValidUsername() method
            value = "колю.фичето";
            Console.WriteLine("Test ToValidUsername() method" + Environment.NewLine + new string('-', 50));
            Console.WriteLine("Input data: {0}", value);
            Console.WriteLine("Output data: {0}", value.ToValidUsername() + Environment.NewLine + new string('-', 50));

            // Test ToValidLatinFileName() method
            value = "тука си записвам едни по особени линкове от нета - НЕ ГЛЕДАЙ.doc";
            Console.WriteLine("Test ToValidLatinFileName() method" + Environment.NewLine + new string('-', 50));
            Console.WriteLine("Input data: {0}", value);
            Console.WriteLine("Output data: {0}", value.ToValidLatinFileName() + Environment.NewLine + new string('-', 50));

            // Test GetFirstCharacters() method
            value = "Get the horse into the river";
            Console.WriteLine("Test GetFirstCharacters() method" + Environment.NewLine + new string('-', 50));
            Console.WriteLine("Input data: {0}", value);
            Console.WriteLine("Output data: {0}", value.GetFirstCharacters(11) + Environment.NewLine + new string('-', 50));

            // Test GetFileExtension() method
            value = "PicFromWebXXXSite.jpg";
            Console.WriteLine("Test GetFileExtension() method" + Environment.NewLine + new string('-', 50));
            Console.WriteLine("Input data: {0}", value);
            Console.WriteLine("Output data: {0}", value.GetFileExtension() + Environment.NewLine + new string('-', 50));

            // Test ToContentType() method
            value = "doc";
            Console.WriteLine("Test ToContentType() method" + Environment.NewLine + new string('-', 50));
            Console.WriteLine("Input data: {0}", value);
            Console.WriteLine("Output data: {0}", value.ToContentType() + Environment.NewLine + new string('-', 50));
        }
    }
}