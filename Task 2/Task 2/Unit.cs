using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    abstract class Unit
    {
        protected int xPosition;
        protected int yPosition;
        protected int health;
        protected int speed;
        protected bool attack;
        protected int attackRange;
        protected string factionTeam;
        protected string symbolImage;
        protected string name;

        #region Constructors
        public Unit()
        {
            xPosition = 0;
            yPosition = 0;
            health = 0;
            speed = 0;
            attack = false;
            attackRange = 0;
            factionTeam = "";
            symbolImage = "";
            name = "";
        }

        public Unit(int xPosition, int yPosition, int health, int speed, bool attack, int attackRange, string factionTeam, string symbolImage, string name)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
            this.health = health;
            this.speed = speed;
            this.attack = attack;
            this.attackRange = attackRange;
            this.factionTeam = factionTeam;
            this.symbolImage = symbolImage;
            this.name = name;
        }
        #endregion

        ~Unit()
        {

        }


        #region Accessors
        public int XPosition
        {
            get { return xPosition; }
            set { xPosition = value; }
        }

        public int YPosition
        {
            get { return yPosition; }
            set { yPosition = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public bool Attack
        {
            get { return attack; }
            set { attack = value; }
        }

        public int AttackRange
        {
            get { return attackRange; }
            set { attackRange = value; }
        }

        public string FactionTeam
        {
            get { return factionTeam; }
            set { factionTeam = value; }
        }

        public string SymbolImage
        {
            get { return symbolImage; }
            set { symbolImage = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion

        public abstract void move(int xPosition, int yPosition);

        public abstract void combat(Unit enemy);

        public abstract bool isEnemyInRange(Unit enemy);

        public abstract Unit nearestUnit(List<Unit> list);

        public abstract bool isAlive();

        public abstract string toString();

        public abstract void save();


    }
}
