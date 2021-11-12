using System;

namespace Project6
{
    class PasswordGenerator
    {
        private static char GetRandomUCase(Random r)
        {
            return (char)(r.Next(0, 26) + 'A');
        }

        private static char GetRandomLCase(Random r)
        {
            return (char)(r.Next(0, 26) + 'a');
        }

        private static char GetRandomDigit(Random r)
        {
            return (char)(r.Next(0, 9) + '0');
        }
        public static string GetPassword()
        {
            char[] passwordChars = new char[8];
            Random r = new Random();
            for (int i = 0; i < passwordChars.Length; i++)
                switch (r.Next(0, 3))
                {
                    case 0:
                        passwordChars[i] = GetRandomDigit(r);
                        break;
                    case 1:
                        passwordChars[i] = GetRandomLCase(r);
                        break;
                    case 2:
                        passwordChars[i] = GetRandomUCase(r);
                        break;
                    default:
                        break;
                }

            int digitPos = r.Next(0, passwordChars.Length);
            passwordChars[digitPos] = GetRandomDigit(r);

            int lCasePos = new int();
            do
                lCasePos = r.Next(0, passwordChars.Length);
            while (lCasePos == digitPos);
            passwordChars[lCasePos] = GetRandomLCase(r);

            int uCasePos = new int();
            do
                uCasePos = r.Next(0, passwordChars.Length);
            while (uCasePos == digitPos || uCasePos == lCasePos);
            passwordChars[uCasePos] = GetRandomUCase(r);

            string password = new string(passwordChars);
            return password;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 0; i < 50; ++i)
                Console.WriteLine(PasswordGenerator.GetPassword());
        }
    }
}