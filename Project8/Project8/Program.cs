using System;
using System.Collections.Generic;

namespace Project8
{
    class Compressor
    {
        public static List<string> getCompressedArray(ref char[] array)
        {
            List<string> compressed = new List<string>();

            int repeatCounter = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if ((i + 1) == array.Length)
                {
                    compressed.Add(array[i].ToString());
                    compressed.Add(repeatCounter.ToString());
                }
                else if (array[i] != array[i + 1])
                {
                    compressed.Add(array[i].ToString());
                    compressed.Add(repeatCounter.ToString());
                    repeatCounter = 1;
                }
                else
                    repeatCounter++;
            }
            return compressed;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            char[] a = { 'D', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'C' };
            List<string> compressed_a = Compressor.getCompressedArray(ref a);
            compressed_a.ForEach(Console.Write);
        }
    }
}