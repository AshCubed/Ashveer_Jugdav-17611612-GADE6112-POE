using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class MeleeUnit : Unit
    {
        private const int damage = 2;

        public MeleeUnit(int xPosition, int yPosition, int health, int speed, bool attack, int attackRange, string factionTeam, string symbolImage)
            :base (xPosition, yPosition, health, speed, attack, attackRange, factionTeam, symbolImage)
        {
            
        }

        public override void move(int xPosition, int yPosition)
        {
            if (xPosition >= 0 && xPosition < 20)
            {
                XPosition = xPosition;
            }
            if (yPosition >= 0 && yPosition < 20)
            {
                YPosition = yPosition;
            }
        }

        override public void combat(Unit enemy)
        {
            if (this.isEnemyInRange(enemy))
            {
                enemy.Health -= damage;
            }
        }

        public override bool isEnemyInRange(Unit enemy)
        {
            if (Math.Abs(this.XPosition - enemy.XPosition) <= this.AttackRange 
                || (Math.Abs(this.YPosition - enemy.YPosition) <= this.AttackRange))
                return true;

            return false;
        }

        override public Unit nearestUnit(List<Unit> list)
        {
            Unit closest = null;
            int attackRangeX, attackRangeY;
            double range;
            double shortestRange = 1000;

            foreach (Unit u in list)
            {
                attackRangeX = Math.Abs(this.XPosition - u.XPosition);
                attackRangeY = Math.Abs(this.YPosition - u.YPosition);

                range = Math.Sqrt(Math.Pow(attackRangeX, 2) + Math.Pow(attackRangeY, 2));

                if (range < shortestRange)
                {
                    shortestRange = range;
                    closest = u;
                }
            }
            return closest;
        }

        override public bool isAlive()
        {
            if (this.Health <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        override public string toString()
        {
            string output = "X :" + XPosition + Environment.NewLine
            + "Y :" + YPosition + Environment.NewLine
            + "Health: " + Health + Environment.NewLine
            + "Speed: " + Speed + Environment.NewLine
            + "Attack: " + (Attack ? "Yes" : "No") + Environment.NewLine
            + "Attack Range: " + AttackRange + Environment.NewLine
            + "Faction: " + FactionTeam + Environment.NewLine
            + "Symboll: " + SymbolImage + Environment.NewLine;
            return output;

        }


    }
}
