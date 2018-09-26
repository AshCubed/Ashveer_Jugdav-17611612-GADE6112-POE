using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Task_2
{
    class ResourceBuilding : Building
    {
        private string resourceType;
        private int resourcesPerGameTick;
        private int resourcesRemaining;

        private int resources = 0;

        #region Accessors
        public string ResourceType
        {
            get { return resourceType; }
            set { resourceType = value; }
        }

        public int ResourcesPerGameTick
        {
            get { return resourcesPerGameTick; }
            set { resourcesPerGameTick = value; }
        }

        public int ResourcesRemaining
        {
            get { return resourcesRemaining; }
            set { resourcesRemaining = value; }
        }
        #endregion

        public ResourceBuilding(int xPosition, int yPosition, int health, string factionTeam, string symbolImage, string resourceType, int resourcesPerGameTick, int resourcesRemaining)
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
            + "Resource Type: " + ResourceType + Environment.NewLine
            + "Resources Per Game Tick: " + ResourcesPerGameTick + Environment.NewLine
            + "Resources Remaining: " + ResourcesRemaining + Environment.NewLine;
            return output;
        }

        override public void save()
        {
            FileStream outFile = null;
            StreamWriter writer = null;

            try
            {
                outFile = new FileStream(@"Files\ResourceBuilding.txt", FileMode.Append, FileAccess.Write);
                writer = new StreamWriter(outFile);

                writer.WriteLine(xPosition);
                writer.WriteLine(yPosition);
                writer.WriteLine(health);
                writer.WriteLine(factionTeam);
                writer.WriteLine(symbolImage);
                writer.WriteLine(resourceType);
                writer.WriteLine(resourcesPerGameTick);
                writer.WriteLine(resourcesRemaining);

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

        public void genResources()
        {
            resources++;
        }

        public void removeResources()
        {
            this.resourcesRemaining--;
        }

    }
}
