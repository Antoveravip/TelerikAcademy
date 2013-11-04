//-----------------------------------------------------------------------
// <copyright file="StringExtensions.cs" company="Telerik Academy">
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
    /// Add extensions methods defined for the <see cref="System.String"/> class.
    /// </summary>
    public static class StringExtensions
    {
        #region Methods
        /// <summary>
        /// Produced MD5 hash value of string.
        /// </summary>
        /// <param name="input">String data</param>
        /// <returns>Returns the MD5 - 128-bit (16-byte) produced hash value of the string.</returns>
        public static string ToMd5Hash(this string input)
        {
            // More for MD5 hash can see at: http://en.wikipedia.org/wiki/Md5
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new StringBuilder to collect the bytes
            // and create a string.
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return builder.ToString();
        }

        /// <summary>
        /// Checks if simple string is positive responsive word
        /// </summary>
        /// <param name="input">String data contains positive answer</param>
        /// <returns><see cref="System.Boolean"/> True of False.</returns>
        public static bool ToBoolean(this string input)
        {
            // May be added more positive responsive word in array to expand method scope
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Parse the string to <see cref="System.Int16"/>.
        /// </summary>
        /// <remarks>
        /// Return 0 if parsing of the string is not correct.
        /// </remarks>
        /// <param name="input">Numeric string data</param>
        /// <returns><see cref="System.Int16"/> value</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// Parse the string to <see cref="System.Int32"/>.
        /// </summary>
        /// <remarks>
        /// Return 0 if parsing of the string is not correct.
        /// </remarks>
        /// <param name="input">Numeric string data</param>
        /// <returns><see cref="System.Int32"/> value</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// Parse the string to <see cref="System.Int64"/>.
        /// </summary>
        /// <remarks>
        /// Return 0 if parsing of the string is not correct.
        /// </remarks>
        /// <param name="input">Numeric string data</param>
        /// <returns><see cref="System.Int64"/> value</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// Parse the string to <see cref="System.DateTime"/>.
        /// </summary>
        /// <remarks>
        /// Return 1.1.0001 00:00:00 if parsing of the string is not correct.
        /// </remarks>
        /// <param name="input">DateTime string data</param>
        /// <returns><see cref="System.DateTime"/> value</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// Capitalize first letter of the string.
        /// </summary>
        /// <param name="input">String data.</param>
        /// <returns>String with capital first letter.</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }
        
        /// <summary>
        /// Get substring between <paramref name="startString"/> and <paramref name="endString"/>.
        /// Get start from <paramref name="startFrom"/> string index.
        /// </summary>
        /// <remarks>
        /// Returns searched substring or empty string if searching index is not correct.
        /// </remarks>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when <paramref name="startFrom"/>
        /// index is greater than string index.
        /// </exception>
        /// <param name="input">String data.</param>
        /// <param name="startString">Start substring</param>
        /// <param name="endString">End substring</param>
        /// <param name="startFrom">Starting string index</param>
        /// <returns>Searched substring or empty string</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Convert string with Cyrillic text to its Latin representation.
        /// </summary>
        /// <param name="input">String data with Cyrillic text.</param>
        /// <returns>String data with Latin text.</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Convert string with Latin text to its Cyrillic representation.
        /// </summary>
        /// <param name="input">String data with Latin text.</param>
        /// <returns>String data with Cyrillic text.</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// Convert <paramref name="input"/> to valid username.
        /// </summary>
        /// <remarks>
        /// Replace Cyrillic letters with their Latin representation, and
        /// remove all non-alphanumeric characters (excluding the period ".").
        /// </remarks>
        /// <param name="input">String with username data</param>
        /// <returns>String with valid username data</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Convert <paramref name="input"/> to valid Latin file name.
        /// </summary>
        /// <remarks>
        /// Replace Cyrillic letters with their Latin representation, spaces are replaced with hyphens
        /// and remove all non-alphanumeric characters (excluding the period "." and hyphen "-").
        /// </remarks>
        /// <param name="input">String with some file name data</param>
        /// <returns>String with valid Latin file name data</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Get first numbers of characters from chosen string.
        /// </summary>
        /// <param name="input">String data</param>
        /// <param name="charsCount">Number of characters to take</param>
        /// <returns>Chosen number of characters from chosen string.</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Get extension of given file.
        /// </summary>
        /// <param name="fileName">String with file and his extension</param>
        /// <returns>Extension of given file</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Show content type of document from given file extension.
        /// </summary>
        /// <param name="fileExtension">String with file extension.</param>
        /// <returns>Content type of document with searched extension.</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Converts each character from chosen string data into a sequence of bytes.
        /// </summary>
        /// <param name="input">String data</param>
        /// <returns>Array with byte representation of each characters.</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
        #endregion
    }
}