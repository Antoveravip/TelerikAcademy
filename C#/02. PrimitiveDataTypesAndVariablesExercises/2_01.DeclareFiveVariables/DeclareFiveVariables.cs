/* Lesson 2 - Primitive Data Types and Variables
 * Homework 1
 * Declare five variables choosing for each of them the most appropriate
 * of the types byte, sbyte, short, ushort, int, uint, long, ulong to
 * represent the following values: 52130, -115, 4825932, 97, -10000.
 */

using System;

class DeclareFiveVariables
{
    static void Main()
    {
        ushort theSecondSmallUnsignedType = 52130;
        sbyte theSmallestSignedType = -115;
        int mostUsedSignedDataType = 4825932;
        byte theSmallestUnsignedType = 97;
        short theSecondSmallSignedType = -10000;
        Console.WriteLine("The data types of the variables is as follow:\n");
        Console.WriteLine("Value {0} is ushort.\nThe range of \"ushort\" data type is from {1} to {2}\n", theSecondSmallUnsignedType, ushort.MinValue, ushort.MaxValue);
        Console.WriteLine("Value {0} is sbyte.\nThe range of \"sbyte\" data type is from {1} to {2}\n", theSmallestSignedType, sbyte.MinValue, sbyte.MaxValue);
        Console.WriteLine("Value {0} is int.\nThe range of \"int\" data type is from {1} to {2}\n", mostUsedSignedDataType, int.MinValue, int.MaxValue);
        Console.WriteLine("Value {0} is byte.\nThe range of \"byte\" data type is from {1} to {2}\n", theSmallestUnsignedType, byte.MinValue, byte.MaxValue);
        Console.WriteLine("Value {0} is short.\nThe range of \"short\" data type is from {1} to {2}\n", theSecondSmallSignedType, short.MinValue, short.MaxValue);
    }
}