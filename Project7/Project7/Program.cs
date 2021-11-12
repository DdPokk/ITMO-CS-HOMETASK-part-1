using System;

namespace Project7
{
    class PlateGenerator
    {
        private static readonly char[] allowedLetters = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'O', 'P', 'T', 'X', 'Y' };
        public static string GetPlate()
        {
            char[] plateSymbols = new char[6];
            Random r = new Random();

            plateSymbols[0] = allowedLetters[r.Next(0, allowedLetters.Length)];
            for (int i = 1; i < 4; i++)
                plateSymbols[i] = Convert.ToChar(Convert.ToString(r.Next(0, 10)));
            for (int i = 4; i < 6; i++)
                plateSymbols[i] = allowedLetters[r.Next(0, allowedLetters.Length)];
            string plate = new string(plateSymbols);
            return plate;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 0; i < 20; ++i)
                Console.WriteLine(PlateGenerator.GetPlate());
        }
    }
}