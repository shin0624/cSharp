using System;
using System.Collections.Generic;
using System.Text;

namespace Text_RPG_2_플레이어_생성
{
    public enum GameMode
    {
        None,
        Lobby,
        Town,
        Field
    }
    class Game//게임 진행 관련 전반적인 사항들을 관리
    {
        private GameMode mode = GameMode.Lobby;
        private Player player = null;
        private Monster monster = null;
        private Random rand = new Random();

        public void Process()
        {
            switch (mode)
            {
                case GameMode.Lobby:
                    ProcessLobby();
                    break;
                case GameMode.Town:
                    ProcessTown();
                    break;
                case GameMode.Field:
                    ProcessField();
                    break;
            }
        }

        private void ProcessLobby()
        {
            Console.WriteLine("직업을 선택하세요");
            Console.WriteLine("[1]기사\n[2]궁수\n[3]법사\n");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    player = new Knight();
                    mode = GameMode.Town;
                    break;
                case "2":
                    player = new Archer();
                    mode = GameMode.Town;
                    break;
                case "3":
                    player = new Mage();
                    mode = GameMode.Town;//직업을 선택하면 town으로 넘어가게 된다
                    break;


            }
        }

        private void ProcessTown()
        {
            Console.WriteLine("마을에 입장했습니다!");
            Console.WriteLine("[1]필드로 입장\n[2]로비로 돌아가기\n");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    mode = GameMode.Field;
                    break;
                case "2":
                    mode = GameMode.Lobby;
                    break;
            }
        }

        private void ProcessField()
        {
            Console.WriteLine("필드에 입장했습니다!");
            Console.WriteLine("[1]전투를 시작한다\n[2]일정 확률로 마을로 돌아가기");

            CreateRandomMonster();

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    ProcessFight();
                    break;

                case "2":
                    TryEscape();
                    break;
            }


        }

        private void TryEscape()
        {
            int randValue = rand.Next(0, 101);
            if(randValue<33)
            {
                mode = GameMode.Town;
            }
            else
            {
                ProcessFight();
            }
        }
        private void ProcessFight()
        {
            while(true)
            {
                int damage = player.GetAttack();//플레이어가 공격했을 때
                monster.OnDamaged(damage);
                if(monster.IsDead())
                {
                    Console.WriteLine("승리했습니다!");
                    Console.WriteLine($"남은 체력{player.GetHp()}");
                    break;
                }

                damage = monster.GetAttack();//몬스터가 공격했을 때
                player.OnDamaged(damage);
                if(player.IsDead())
                {
                    Console.WriteLine("패배했습니다! 로비로 이동합니다");
                    mode = GameMode.Lobby;
                    break;
                }
            }
        }
        private void CreateRandomMonster()
        {
            int randValue = rand.Next(0, 3);
            switch (randValue)
            {
                case 0:
                    monster = new Slime();
                    Console.WriteLine("슬라임이 생성되었습니다!");
                    break;

                case 1:
                    monster = new Ork();
                    Console.WriteLine("오크가 생성되었습니다!");
                    break;

                case 2:
                    monster = new Skeleton();
                    Console.WriteLine("스켈레톤이 생성되었습니다!");
                    break;
            }
        }
    }
}
