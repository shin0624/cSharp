using System;

namespace 소수판별코드_연습
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("입력된 숫자의 소수 유무를 판단하는 프로그램입니다.\n소수:1과 자기자신만으로 나누어떨어지는 수");

           int num = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<=num;i++)
            {
                if(num==2)
                {
                    Console.WriteLine("소수입니다!(2는 유일한 짝수소수)");
                    break;
                }
                if((num%2)==0)
                {
                    Console.WriteLine("소수가 아닙니다!");
                    break;
                }
                else
                {
                    Console.WriteLine("소수입니다!");
                    break;
                }

            }


        }
    }
}
