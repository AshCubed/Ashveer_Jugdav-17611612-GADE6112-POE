using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    abstract class Building
    {
        protected int xPosition;
        protected int yPosition;
        protected int health;
        protected string factionTeam;
        protected string symbolImage;

        #region Constructors
        public Building()
        {
            xPosition = 0;
            yPosition = 0;
            health = 0;
            factionTeam = "";
            symbolImage = "";
        }

        public Building(int xPosition, int yPosition, int health, string factionTeam, string symbolImage)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
            this.health = health;
            this.factionTeam = factionTeam;
            this.symbolImage = symbolImage;
        }
        #endregion

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
        #endregion

        public abstract bool deathDestruction();

        public abstract string toString();

        public abstract void save();


    }
}
