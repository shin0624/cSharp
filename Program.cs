using System;

namespace while문_연습
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("강사님은 잘생기셨나요?(y/n) : ");
                 answer = Console.ReadLine();


            } while (answer != "y");
            Console.WriteLine("정답입니다!");
        }

    }
}
