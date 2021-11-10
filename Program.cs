using System;

namespace 코드의_흐름_연습문제_답
{
    class Program
    {
        static void Main(string[] args)
        {
           for (int i=2; i<=9; i++)
            {
                for(int j=1; j<=9; j++)
                {
                    Console.WriteLine($"{i}*{j}={i*j}");
                }
            }
        }
    }
}
