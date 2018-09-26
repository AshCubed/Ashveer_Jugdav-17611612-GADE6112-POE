using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Task_2
{
    class FactoryBuilding : Building
    {
        private int unitsToProduce;
        private int gameTicksPerProduction;
        private int spawnPoint;

        #region Accessors
        public int UnitsToProduce
        {
            get { return unitsToProduce; }
            set { unitsToProduce = value; }
        }

        public int GameTicksPerProduction
        {
            get { return gameTicksPerProduction; }
            set { gameTicksPerProduction = value; }
        }

        public int SpawnPoint
        {
            get { return spawnPoint; }
            set { spawnPoint = value; }
        }
        #endregion

        public FactoryBuilding(int xPosition, int yPosition, int health, string factionTeam, string symbolImage, int unitsToProduce, int gameTicksPerProduction, int spawnPoint)
            : base(xPosition, yPosition, health, factionTeam, symbolImage)
        {
            
        }

        override public bool deathDestruction()
        {
            if (this.Health <= 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        override public string toString()
        {
            string output = "X :" + XPosition + Environment.NewLine
            + "Y :" + YPosition + Environment.NewLine
            + "Health: " + Health + Environment.NewLine
            + "Faction: " + FactionTeam + Environment.NewLine
            + "Symboll: " + SymbolImage + Environment.NewLine
            + "Units To Produce: " + UnitsToProduce + Environment.NewLine
            + "Game Ticks Per Production: " + GameTicksPerProduction + Environment.NewLine
            + "Spawn Point: " + SpawnPoint + Environment.NewLine;
            return output;
        }

        override public void save()
        {
            FileStream outFile = null;
            StreamWriter writer = null;

            try
            {
                outFile = new FileStream(@"Files\FactoryBuilding.txt", FileMode.Append, FileAccess.Write);
                writer = new StreamWriter(outFile);

                writer.WriteLine(xPosition);
                writer.WriteLine(yPosition);
                writer.WriteLine(health);
                writer.WriteLine(factionTeam);
                writer.WriteLine(symbolImage);
                writer.WriteLine(unitsToProduce);
                writer.WriteLine(gameTicksPerProduction);
                writer.WriteLine(spawnPoint);

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

        public void spawnNewUnits()
        {

        }
    }
}
