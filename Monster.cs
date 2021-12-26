using System;
using System.Collections.Generic;
using System.Text;

namespace Text_RPG_2_플레이어_생성
{
    public enum MonsterType
    {
        None = 0,
        Slime = 1,
        Ork = 2,
        Skeleton = 3
    }
    
    class Monster : Creature
    {
        protected MonsterType type;
        protected Monster(MonsterType type) : base(CreatureType.Monster)
        {
            this.type = type;
        }
        MonsterType GetMonsterType() { return type; }
    }

    class Slime : Monster
    {
        public Slime() : base(MonsterType.Slime)
        {
            SetInfo(10, 1);
        }
    }
    class Ork : Monster
    {
        public Ork() : base(MonsterType.Ork)
        {
            SetInfo(20, 2);
        }
    }
    class Skeleton : Monster
    {
        public Skeleton() : base(MonsterType.Skeleton)
        {
            SetInfo(15, 5);
        }
    }

}
