using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Task_2
{
    class MeleeUnit : Unit
    {
        private const int damage = 2;

        public MeleeUnit(int xPosition, int yPosition, int health, int speed, bool attack, int attackRange, string factionTeam, string symbolImage, string name)
            :base (xPosition, yPosition, health, speed, attack, attackRange, factionTeam, symbolImage, name)
        {
            
        }

        override public void move(int xPosition, int yPosition)
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

        override public bool isEnemyInRange(Unit enemy)
        {
            if (Math.Abs(this.XPosition - enemy.XPosition) <= this.AttackRange || (Math.Abs(this.YPosition - enemy.YPosition) <= this.AttackRange))
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
                if (!this.FactionTeam.Equals(u.FactionTeam))
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
            + "Symboll: " + SymbolImage + Environment.NewLine
            + "Name: " + Name + Environment.NewLine;
            return output;

        }

        override public void save()
        {
            FileStream outFile = null;
            StreamWriter writer = null;

            try
            {
                outFile = new FileStream(@"Files\MeleeUnit.txt", FileMode.Append, FileAccess.Write);
                writer = new StreamWriter(outFile);

                writer.WriteLine(xPosition);
                writer.WriteLine(yPosition);
                writer.WriteLine(health);
                writer.WriteLine(speed);
                writer.WriteLine(attack);
                writer.WriteLine(attackRange);
                writer.WriteLine(factionTeam);
                writer.WriteLine(symbolImage);
                writer.WriteLine(name);

                writer.Close();
                outFile.Close();
            }
            catch (Exception fe)
            {
                Debug.WriteLine(fe.Message);
            }
            finally
            {
                if (outFile != null)
                {
                    outFile.Close();
                    writer.Close();
                }
            }
        }
    }
}
