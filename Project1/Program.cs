using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;//число до которого будем находить простые числа
            N = int.Parse(Console.ReadLine());//вводим N
            for (int i = 2; i <= N; i++)
            {
                if (isSimple(i))
                {
                    Console.Write(i.ToString() + ",");
                }
            }
        }
        //метод который определяет простое число или нет
        private static bool isSimple(int N)
        {
            //чтоб убедится простое число или нет достаточно проверить не делитсья ли 
            //число на числа до его половины
            for (int i = 2; i < (int)(N / 2); i++)
            {
                if (N % i == 0)
                    return false;
            }
            return true;
        }
    }
}