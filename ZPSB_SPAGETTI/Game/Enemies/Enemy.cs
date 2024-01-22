using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPSB_SPAGETTI.Game.Enemies
{
    // Ogólnie jest to klasa Enemy która będzie miała basic stuff jeżeli będziemy robić specyficznych przeciwników to będziemy dziedziczyć tą
    class Enemy
    {
        private string name;
        private int hp;
        private int damage;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }

        public int Damage
        {
            get { return damage; }
            set {damage = value; }
        }

        public Enemy(string cname, int chp, int cdamage)
        {
            Name = cname;
            Hp = chp;
            Damage = cdamage;
        }

        public void TakeDamage(int dmg)
        {
            hp -= dmg;
            if (hp <= 0)
            {
                SlayEnemy();
            }
        }

        public void SlayEnemy()
        {
            // Slay Queen
        }
    }
}
