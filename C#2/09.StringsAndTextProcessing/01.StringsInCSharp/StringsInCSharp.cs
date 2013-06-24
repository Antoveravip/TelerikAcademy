/* Lesson 9 - Strings and Text Processing
 * Homework 1
 * 
 * Describe the strings in C#. What is typical for the
 * string data type? Describe the most important methods
 * of the String class.
 */

using System;
using System.Text;

class StringsInCSharp
{
    static void Main()
    {
        //TODO More examples
        /*
        //01.Describe the strings in C#. What is typical for the string data type?
        
        Strings are sequences of characters.
        Each character is a Unicode symbol.
        Represented by the string data type in C# (System.String).
        Strings are represented by System.String objects in .NET Framework.
        String objects contain an immutable (read-only) sequence of characters.
        Strings use Unicode to support multiple languages and alphabets.
        Strings are stored in the dynamic memory (managed heap).
        System.String is reference type.
        String objects are like arrays of characters (char[]).
        Have fixed length (String.Length).
        Elements can be accessed directly by index.
        The index is in the range [0...Length-1].
        For more informations visit http://msdn.microsoft.com/en-us/library/s1wwdcbf.aspx
        */
        //02.System.String Constructors:

        //String(Char*), String(Char[])        
        // Unicode Letterlike Symbols 
        char[] charArray = { '\u2111', '\u2118', '\u2122', '\u2126' };
        String szLetterLike = new String(charArray);

        //String(SByte*)        
        // Null terminated ASCII characters in an sbyte array
        String szAsciiUpper = null;
        sbyte[] sbArr1 = new sbyte[] { 0x41, 0x42, 0x43, 0x00 };
        Console.WriteLine(szAsciiUpper);

        //String(Char, Int32)    
        // Create a Unicode String with 5 Greek Alpha characters
        String szGreekAlpha = new String('\u0391', 5);

        //String(Char*, Int32, Int32), String(Char[], Int32, Int32)
        // Create a Unicode String with a Greek Omega character
        String szGreekOmega = new String(new char[] { '\u03A9', '\u03A9', '\u03A9' }, 2, 1);

        //String(SByte*, Int32, Int32), String(SByte*, Int32, Int32, Encoding)
        unsafe
        {
            String utfeightstring = null;
            sbyte[] asciiChars = new sbyte[] { 0x51, 0x52, 0x53, 0x54, 0x54, 0x56 };
            UTF8Encoding encoding = new UTF8Encoding(true, true);

            // Instruct the Garbage Collector not to move the memory 
            fixed (sbyte* pAsciiChars = asciiChars)
            {
                utfeightstring = new String(pAsciiChars, 0, asciiChars.Length, encoding);
            }
            Console.WriteLine("The UTF8 String is " + utfeightstring); // prints "QRSTTV"
        }

        //03.System.String Properties
        //Chars Property
        string str1 = "Test";
        for (int ctr = 0; ctr <= str1.Length - 1; ctr++)
        {
            Console.Write("{0} ", str1[ctr]);
        }
        //Length Property
        string str = "abcdefg";
        Console.WriteLine("1) The length of '{0}' is {1}", str, str.Length);

        //04.System.String Methods

        //Clone Method - the return value is not an independent copy of this instance; it is simply another view of the same data
        string cloneStr = "abcdefg";
        object str2 = cloneStr.Clone();

        //Compare Method  - + 9 overloads - compares tho strings, with default or other options, with culture info, etc.
        /*
          Compare(String, String)
          Compare(String, String, Boolean)
          Compare(String, String, StringComparison)
          Compare(String, String, Boolean, CultureInfo)
          Compare(String, String, CultureInfo, CompareOptions)
          Compare(String, Int32, String, Int32, Int32)
          Compare(String, Int32, String, Int32, Int32, Boolean)
          Compare(String, Int32, String, Int32, Int32, StringComparison)
          Compare(String, Int32, String, Int32, Int32, Boolean, CultureInfo)
          Compare(String, Int32, String, Int32, Int32, CultureInfo, CompareOptions)
        */

        //CompareOrdinal Method (String, String) and CompareOrdinal(String, Int32, String, Int32, Int32)
        //Performs a case-sensitive comparison using ordinal sort rules

        //Method CompareTo(String) and CompareTo(Object) - This method performs a word (case-sensitive and culture-sensitive) comparison using the current culture

        //Method Concat + 9 overloads is used to combine strings
        string strg1 = "We can ", strg2 = "do it!";
        string strg = String.Concat(strg1, strg2);

        //Contains Method - Returns a value indicating whether the specified String object occurs within this string.

        //Copy Method - Creates a new instance of String with the same value as a specified String.

        //CopyTo Method - Copies a specified number of characters from a specified position in this instance to a specified position in an array of Unicode characters.

        //EndsWith Method with  + 2 overloads - Determines whether the end of this string instance matches the specified string.

        //Equals Method (Object) + 3 overloads - Determines whether this instance and a specified object, which must also be a String object, have the same value.

        //Format Method (String, Object) + 4 overloads - Replaces one or more format items in a specified string with the string representation of a specified object.

        //GetEnumerator Method - Retrieves an object that can iterate through the individual characters in this string.

        //GetHashCode Method - Returns the hash code for this string.

        //GetType Method - Gets the Type of the current instance.

        //GetTypeCode Method  - Returns the TypeCode for class String.

        //IndexOf Method (Char) + 8 overloads - Reports the zero-based index of the first occurrence of the specified Unicode character in this string.

        //Insert Method - Returns a new string in which a specified string is inserted at a specified index position in this instance. 

        //Intern Method - Retrieves the system's reference to the specified String.

        //IsNormalized Method + 1 overload - Indicates whether this string is in Unicode normalization form C.

        //IsNullOrEmpty Method - Indicates whether the specified string is null or an Empty string.

        //IsNullOrWhiteSpace Method - Indicates whether a specified string is null, empty, or consists only of white-space characters.

        //Join Method (String, IEnumerable<String>) + 3 overloads- Concatenates the members of a constructed IEnumerable<T> collection of type String, using the specified separator between each member.

        //Join<T> Method (String, IEnumerable<T>) - Concatenates the members of a collection, using the specified separator between each member.

        //LastIndexOf Method (Char) + 8 overloads - Reports the zero-based index position of the last occurrence of a specified Unicode character within this instance.

        //LastIndexOfAny Method (Char[]) + 2 overloads - Reports the zero-based index position of the last occurrence in this instance of one or more characters specified in a Unicode array.

        //Normalize Method + 1 overloads - Returns a new string whose textual value is the same as this string, but whose binary representation is in Unicode normalization form C.

        //PadLeft Method (Int32) + 1 overload - Returns a new string that right-aligns the characters in this instance by padding them with spaces on the left, for a specified total length.

        //PadRight Method (Int32) + 1 overload - Returns a new string that left-aligns the characters in this string by padding them with spaces on the right, for a specified total length.

        //Remove Method (Int32) + 1 overload - Returns a new string in which all the characters in the current instance, beginning at a specified position and continuing through the last position, have been deleted.
        string price = "$ 1234567";
        string lowPrice = price.Remove(2, 3);
        Console.WriteLine(lowPrice);

        //Replace Method (Char, Char) + 1 overload - Returns a new string in which all occurrences of a specified Unicode character in this instance are replaced with another specified Unicode character.
        string cocktail = "Vodka + Martini + Cherry";
        string replaced = cocktail.Replace("+", "and");
        Console.WriteLine(replaced);

        //Split Method (Char[]) + 5 overloads - Returns a string array that contains the substrings in this instance that are delimited by elements of a specified Unicode character array.

        //StartsWith Method (String) + 2 overloads - Determines whether the beginning of this string instance matches the specified string.

        //Substring Method (Int32) + 1 overload - Retrieves a substring from this instance. The substring starts at a specified character position.

        //ToCharArray Method + 1 overload - Copies the characters in this instance to a Unicode character array.

        //ToLower Method  + 1 overload - Returns a copy of this string converted to lowercase.

        //ToLowerInvariant Method - Returns a copy of this String object converted to lowercase using the casing rules of the invariant culture.

        //ToString Method  + 1 overload - Returns this instance of String; no actual conversion is performed.

        //ToUpper Method + 1 overload - Returns a copy of this string converted to uppercase.

        //ToUpperInvariant Method - Returns a copy of this String object converted to uppercase using the casing rules of the invariant culture.

        string alpha = "aBcDeFg";
        string lowerAlpha = alpha.ToLower(); //lowercase conversion example
        Console.WriteLine(lowerAlpha);
        string upperAlpha = alpha.ToUpper(); // uppercase conversion examples
        Console.WriteLine(upperAlpha);

        //Trim Method + 1 overload - Removes all leading and trailing white-space characters from the current String object.

        string s = "  example of white space ";
        string clean = s.Trim(); //Trim() example
        Console.WriteLine(clean);

        s = " \t\nHello!!! \n";
        clean = s.Trim(' ', ',', '!', '\n', '\t'); // Trim(chars) example
        Console.WriteLine(clean);

        //TrimEnd Method - Removes all trailing occurrences of a set of characters specified in an array from the current String object.

        s = "   C#   ";
        clean = s.TrimEnd(); // TrimEnd() example
        Console.WriteLine(clean);

        //TrimStart Method - Removes all leading occurrences of a set of characters specified in an array from the current String object.

        s = "   C#   ";
        clean = s.TrimStart(); // TrimStart() example
        Console.WriteLine(clean);
    }
}