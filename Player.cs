using System;
using System.Collections.Generic;
using System.Text;

namespace Text_RPG_2_플레이어_생성
{
    public enum PlayerType
    {
        None = 0,
        Knght = 1,
        Archer = 2,
        Mage = 3
    }

    class Player
    {
        protected PlayerType type = PlayerType.None;
        protected int hp = 0;
        protected int attack = 0;

        public void SetInfo(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;
        }

        protected Player(PlayerType type)//->외부에서 플레이어타입을 넣어도 플레이어 접근x->직업 3개중 하나로 간접적으로 접근하도록(은닉성 응용)
        {
            this.type = type;//-->program에서 인자를 갖는 버전을 만들게되면 더이상 인자가 없는 hp와 attack은 사용 불가하게 함
        }

        public int GetHp() { return hp; }//체력과 공격을 protected로 했기 때문에 넣어줌
        public int GetAttack() { return attack; }

        public bool IsDead() { return hp <= 0; }

        public void OnDamaged(int damage)
        {
            hp -= damage;
            if (hp < 0)
                hp = 0;
        }


    }

    class Knight : Player
    {
       public Knight() : base(PlayerType.Knght)//생성자 = 이름이  class와 같고 반환형식이 없는것
        {
            SetInfo(100, 10);

        }
    }

    class Archer : Player
    {
         public Archer() : base(PlayerType.Archer)//->부모클래스의 생성자를 사용토록 함
        {
            SetInfo(75, 12);
        }
    
    }

    class Mage : Player
    {
        public Mage() : base(PlayerType.Mage)//-->public을 안붙이면 외부에서 캐릭터 생성이 불가능
        {
            SetInfo(50, 15);
        }
    }



}
