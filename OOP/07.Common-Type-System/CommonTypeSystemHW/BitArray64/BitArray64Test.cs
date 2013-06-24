namespace BitArray64
{
    using System;

    class BitArray64Test
    {
        static void Main()
        {
            Console.WriteLine("First BitArray64 array");
            BitArray64 array = new BitArray64(6);
            array.Add(0);
            array.Add(18446744073709551615);
            array.Add(152228884);
            array.Add(18446744073709551615);
            array.Add(8786265576);
            array.Add(18446744073709551615);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Second BitArray64 array");
            BitArray64 newArray = new BitArray64(6);
            newArray.Add(18446744073709551615);
            newArray.Add(775727);
            newArray.Add(1244787811);
            newArray.Add(123456789);
            newArray.Add(123456789);
            newArray.Add(18446744073709551615);

            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Check if two arrays are equals: {0}!", array.Equals(newArray));
            Console.WriteLine("Hashcode: {0}", array.GetHashCode());

            newArray[0] = 0;
            Console.WriteLine("The new value of newArray at zero positions is: {0}", newArray[0]);

            Console.WriteLine("Check for equality: {0}", array == newArray);
            Console.WriteLine("Check for difference: {0}", array != newArray);
        }
    }
}