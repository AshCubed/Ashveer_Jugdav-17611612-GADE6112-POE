using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Task_3
{
    class GatewayBuilding : Building
    {
        public GatewayBuilding(int xPosition, int yPosition, int health, string factionTeam, string symbolImage)
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
            + "Symboll: " + SymbolImage + Environment.NewLine;
            return output;
        }

        override public void save()
        {
            FileStream outFile = null;
            StreamWriter writer = null;

            try
            {
                outFile = new FileStream(@"Files\GateWayBuilding.txt", FileMode.Append, FileAccess.Write);
                writer = new StreamWriter(outFile);

                writer.WriteLine(xPosition);
                writer.WriteLine(yPosition);
                writer.WriteLine(health);
                writer.WriteLine(factionTeam);
                writer.WriteLine(symbolImage);

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

        public Unit spawnNewUnits()
        {
            return null;
        }
    }
}
