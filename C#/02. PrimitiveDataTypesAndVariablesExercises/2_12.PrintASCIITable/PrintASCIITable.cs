/* Lesson 2 - Primitive Data Types and Variables
 * Homework 12
 * Find online more information about ASCII (American Standard Code for Information Interchange)
 * and write a program that prints the entire ASCII table of characters on the console.
 */

using System;
using System.Text;

class PrintASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine("\nASCII Table and Description\n");
        Console.WriteLine(new string('-', 38) + "\n| Dec | Oct | Hex|  Bynary  | Symbol |\n" + new string('-', 38));
        byte minSignValue = 0;
        byte maxSignValue = 255;
        int n = 0;
        for (n = minSignValue; n <= 127; n++)
        {
            // Get ascii character.
            char c = (char)n;
            // Get display string.
            string asciiView = string.Empty;
            if (char.IsWhiteSpace(c))
            {
                asciiView = c.ToString();
                switch (c)
                {
                    case '\t': { asciiView = "HT"; break; }
                    case '\n': { asciiView = "LF"; break; }
                    case '\v': { asciiView = "VT"; break; }
                    case '\f': { asciiView = "FF"; break; }
                    case '\r': { asciiView = "CR"; break; }
                    case ' ': { asciiView = "Space"; break; }
                    default: { break; }
                }
            }
            else if (char.IsControl(c))
            {
                switch (n)
                {
                    case 0: { asciiView = "NUL"; break; }
                    case 1: { asciiView = "SOH"; break; }
                    case 2: { asciiView = "STX"; break; }
                    case 3: { asciiView = "ETX"; break; }
                    case 4: { asciiView = "EOT"; break; }
                    case 5: { asciiView = "ENQ"; break; }
                    case 6: { asciiView = "ACK"; break; }
                    case 7: { asciiView = "BEL"; break; }
                    case 8: { asciiView = "BS"; break; }
                    case 14: { asciiView = "SO"; break; }
                    case 15: { asciiView = "SI"; break; }
                    case 16: { asciiView = "DLE"; break; }
                    case 17: { asciiView = "DC1"; break; }
                    case 18: { asciiView = "DC2"; break; }
                    case 19: { asciiView = "DC3"; break; }
                    case 20: { asciiView = "DC4"; break; }
                    case 21: { asciiView = "NAK"; break; }
                    case 22: { asciiView = "SYN"; break; }
                    case 23: { asciiView = "ETB"; break; }
                    case 24: { asciiView = "CAN"; break; }
                    case 25: { asciiView = "EM"; break; }
                    case 26: { asciiView = "SUB"; break; }
                    case 27: { asciiView = "ESC"; break; }
                    case 28: { asciiView = "FS"; break; }
                    case 29: { asciiView = "GS"; break; }
                    case 30: { asciiView = "RS"; break; }
                    case 31: { asciiView = "US"; break; }
                    case 127: { asciiView = "Delete"; break; }
                    default: { break; }
                }
            }
            else
            {
                asciiView = c.ToString();
            }
            Console.WriteLine("| {0,3} | {2} | {0:X2} | {3} | {4} |", n, n.ToString().PadLeft(3), (Convert.ToString(n, 8).PadLeft(3, '0')), (Convert.ToString(n, 2).PadLeft(8, '0')), asciiView.PadRight(6));
        }
        Console.WriteLine("\n\nASCII Table - Extended ASCII Codes and Description\n");
        Console.WriteLine(new string('-', 79) + "\n| Dec | Oct | Hex|  Bynary  | Symbol | Symbol Explanation" + new string(' ', 21) + "|\n" + new string('-', 79));
        for (n = 128; n <= maxSignValue; n++)
        {
            // Get ascii character.
            char c = (char)n;
            // Get display string.
            string asciiView = string.Empty;
            string asciiExp = string.Empty;
            asciiExp = n.ToString();
            switch (n)
            {
                case 128: { asciiExp = "Euro sign"; break; }
                case 129: { asciiExp = "empty"; break; }
                case 130: { asciiExp = "Single low-9 quotation mark"; break; }
                case 131: { asciiExp = "Latin small letter f with hook"; break; }
                case 132: { asciiExp = "Double low-9 quotation mark"; break; }
                case 133: { asciiExp = "Horizontal ellipsis"; break; }
                case 134: { asciiExp = "Dagger"; break; }
                case 135: { asciiExp = "Double dagger"; break; }
                case 136: { asciiExp = "Modifier letter circumflex accent"; break; }
                case 137: { asciiExp = "Per mille sign"; break; }
                case 138: { asciiExp = "Latin capital letter S with caron"; break; }
                case 139: { asciiExp = "Single left-pointing angle quotation"; break; }
                case 140: { asciiExp = "Latin capital ligature OE"; break; }
                case 141: { asciiExp = "empty"; break; }
                case 142: { asciiExp = "Latin captial letter Z with caron"; break; }
                case 143: { asciiExp = "empty"; break; }
                case 144: { asciiExp = "empty"; break; }
                case 145: { asciiExp = "Left single quotation mark"; break; }
                case 146: { asciiExp = "Right single quotation mark"; break; }
                case 147: { asciiExp = "Left double quotation mark"; break; }
                case 148: { asciiExp = "Right double quotation mark"; break; }
                case 149: { asciiExp = "Bullet"; break; }
                case 150: { asciiExp = "En dash"; break; }
                case 151: { asciiExp = "Em dash"; break; }
                case 152: { asciiExp = "Small tilde"; break; }
                case 153: { asciiExp = "Trade mark sign"; break; }
                case 154: { asciiExp = "Latin small letter S with caron"; break; }
                case 155: { asciiExp = "Single right-pointing angle quot.mark"; break; }
                case 156: { asciiExp = "Latin small ligature oe"; break; }
                case 157: { asciiExp = "empty"; break; }
                case 158: { asciiExp = "Latin small letter z with caron"; break; }
                case 159: { asciiExp = "Latin capital letter Y with diaeresis"; break; }
                case 160: { asciiExp = "Non-breaking space"; break; }
                case 161: { asciiExp = "Inverted exclamation mark"; break; }
                case 162: { asciiExp = "Cent sign"; break; }
                case 163: { asciiExp = "Pound sign"; break; }
                case 164: { asciiExp = "Currency sign"; break; }
                case 165: { asciiExp = "Yen sign"; break; }
                case 166: { asciiExp = "Pipe, Broken vertical bar"; break; }
                case 167: { asciiExp = "Section sign"; break; }
                case 168: { asciiExp = "Spacing diaeresis - umlaut"; break; }
                case 169: { asciiExp = "Copyright sign"; break; }
                case 170: { asciiExp = "Feminine ordinal indicator"; break; }
                case 171: { asciiExp = "Left double angle quotes"; break; }
                case 172: { asciiExp = "Not sign"; break; }
                case 173: { asciiExp = "Soft hyphen"; break; }
                case 174: { asciiExp = "Registered trade mark sign"; break; }
                case 175: { asciiExp = "Spacing macron - overline"; break; }
                case 176: { asciiExp = "Degree sign"; break; }
                case 177: { asciiExp = "Plus-or-minus sign"; break; }
                case 178: { asciiExp = "Superscript two - squared"; break; }
                case 179: { asciiExp = "Superscript three - cubed"; break; }
                case 180: { asciiExp = "Acute accent - spacing acute"; break; }
                case 181: { asciiExp = "Micro sign"; break; }
                case 182: { asciiExp = "Pilcrow sign - paragraph sign"; break; }
                case 183: { asciiExp = "Middle dot - Georgian comma"; break; }
                case 184: { asciiExp = "Spacing cedilla"; break; }
                case 185: { asciiExp = "Superscript one"; break; }
                case 186: { asciiExp = "Masculine ordinal indicator"; break; }
                case 187: { asciiExp = "Right double angle quotes"; break; }
                case 188: { asciiExp = "Fraction one quarter"; break; }
                case 189: { asciiExp = "Fraction one half"; break; }
                case 190: { asciiExp = "Fraction three quarters"; break; }
                case 191: { asciiExp = "Inverted question mark"; break; }
                case 192: { asciiExp = "Latin capital letter A with grave"; break; }
                case 193: { asciiExp = "Latin capital letter A with acute"; break; }
                case 194: { asciiExp = "Latin capital letter A with circumflex"; break; }
                case 195: { asciiExp = "Latin capital letter A with tilde"; break; }
                case 196: { asciiExp = "Latin capital letter A with diaeresis"; break; }
                case 197: { asciiExp = "Latin capital letter A with ring above"; break; }
                case 198: { asciiExp = "Latin capital letter AE"; break; }
                case 199: { asciiExp = "Latin capital letter C with cedilla"; break; }
                case 200: { asciiExp = "Latin capital letter E with grave"; break; }
                case 201: { asciiExp = "Latin capital letter E with acute"; break; }
                case 202: { asciiExp = "Latin capital letter E with circumflex"; break; }
                case 203: { asciiExp = "Latin capital letter E with diaeresis"; break; }
                case 204: { asciiExp = "Latin capital letter I with grave"; break; }
                case 205: { asciiExp = "Latin capital letter I with acute"; break; }
                case 206: { asciiExp = "Latin capital letter I with circumflex"; break; }
                case 207: { asciiExp = "Latin capital letter I with diaeresis"; break; }
                case 208: { asciiExp = "Latin capital letter ETH"; break; }
                case 209: { asciiExp = "Latin capital letter N with tilde"; break; }
                case 210: { asciiExp = "Latin capital letter O with grave"; break; }
                case 211: { asciiExp = "Latin capital letter O with acute"; break; }
                case 212: { asciiExp = "Latin capital letter O with circumflex"; break; }
                case 213: { asciiExp = "Latin capital letter O with tilde"; break; }
                case 214: { asciiExp = "Latin capital letter O with diaeresis"; break; }
                case 215: { asciiExp = "Multiplication sign"; break; }
                case 216: { asciiExp = "Latin capital letter O with slash"; break; }
                case 217: { asciiExp = "Latin capital letter U with grave"; break; }
                case 218: { asciiExp = "Latin capital letter U with acute"; break; }
                case 219: { asciiExp = "Latin capital letter U with circumflex"; break; }
                case 220: { asciiExp = "Latin capital letter U with diaeresis"; break; }
                case 221: { asciiExp = "Latin capital letter Y with acute"; break; }
                case 222: { asciiExp = "Latin capital letter THORN"; break; }
                case 223: { asciiExp = "Latin small letter sharp s - ess-zed"; break; }
                case 224: { asciiExp = "Latin small letter a with grave"; break; }
                case 225: { asciiExp = "Latin small letter a with acute"; break; }
                case 226: { asciiExp = "Latin small letter a with circumflex"; break; }
                case 227: { asciiExp = "Latin small letter a with tilde"; break; }
                case 228: { asciiExp = "Latin small letter a with diaeresis"; break; }
                case 229: { asciiExp = "Latin small letter a with ring above"; break; }
                case 230: { asciiExp = "Latin small letter ae"; break; }
                case 231: { asciiExp = "Latin small letter c with cedilla"; break; }
                case 232: { asciiExp = "Latin small letter e with grave"; break; }
                case 233: { asciiExp = "Latin small letter e with acute"; break; }
                case 234: { asciiExp = "Latin small letter e with circumflex"; break; }
                case 235: { asciiExp = "Latin small letter e with diaeresis"; break; }
                case 236: { asciiExp = "Latin small letter i with grave"; break; }
                case 237: { asciiExp = "Latin small letter i with acute"; break; }
                case 238: { asciiExp = "Latin small letter i with circumflex"; break; }
                case 239: { asciiExp = "Latin small letter i with diaeresis"; break; }
                case 240: { asciiExp = "Latin small letter eth"; break; }
                case 241: { asciiExp = "Latin small letter n with tilde"; break; }
                case 242: { asciiExp = "Latin small letter o with grave"; break; }
                case 243: { asciiExp = "Latin small letter o with acute"; break; }
                case 244: { asciiExp = "Latin small letter o with circumflex"; break; }
                case 245: { asciiExp = "Latin small letter o with tilde"; break; }
                case 246: { asciiExp = "Latin small letter o with diaeresis"; break; }
                case 247: { asciiExp = "Division sign"; break; }
                case 248: { asciiExp = "Latin small letter o with slash"; break; }
                case 249: { asciiExp = "Latin small letter u with grave"; break; }
                case 250: { asciiExp = "Latin small letter u with acute"; break; }
                case 251: { asciiExp = "Latin small letter u with circumflex"; break; }
                case 252: { asciiExp = "Latin small letter u with diaeresis"; break; }
                case 253: { asciiExp = "Latin small letter y with acute"; break; }
                case 254: { asciiExp = "Latin small letter thorn"; break; }
                case 255: { asciiExp = "Latin small letter y with diaeresis"; break; }
                default: { break; }
            }
            if (char.IsWhiteSpace(c))
            {
                asciiView = c.ToString();
                switch (c)
                {
                    case '\t': { asciiView = "HT"; break; }
                    case '\n': { asciiView = "LF"; break; }
                    case '\v': { asciiView = "VT"; break; }
                    case '\f': { asciiView = "FF"; break; }
                    case '\r': { asciiView = "CR"; break; }
                    case ' ': { asciiView = "Space"; break; }
                    default: { break; }
                }
            }
            else
            {
                asciiView = c.ToString();
            }
            Console.WriteLine("| {0,3} | {2} | {0:X2} | {3} | {4} | {5} |", n, n.ToString().PadLeft(3), (Convert.ToString(n, 8).PadLeft(3, '0')), (Convert.ToString(n, 2).PadLeft(8, '0')), asciiView.PadRight(6), asciiExp.PadRight(38));
        }
        Console.WriteLine(new string('-', 79) + "\n| Dec | Oct | Hex|  Bynary  | Symbol | Symbol Explanation" + new string(' ', 21) + "|\n" + new string('-', 79));
    }
}