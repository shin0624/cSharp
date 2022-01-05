using System;

namespace Text_RPG_2_플레이어_생성
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            while(true)
            {
                game.Process();
            }
        }
    }
}
//OOP를 학습 한 후 만든 text RPG의 특징 = 함수 서로의 책임에 따라 코드를 깔끔하게 분리시키고 관리하는 주체도 CLASS로 분리, 코드를 보기 편하게 만듦,
//모드를 분리해서 관리할 수 있음
