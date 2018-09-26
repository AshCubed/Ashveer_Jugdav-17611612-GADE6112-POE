using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task_1
{
    class GameEngine
    {
        private Map m = new Map();

        public void rules(int i)
        {
            m.checkHealth();
            int currentX = m.unitsOnMap[i].XPosition;
            int currentY = m.unitsOnMap[i].YPosition;

            Unit closestUnit = m.unitsOnMap[i].nearestUnit(m.unitsOnMap);

            #region Unit basic movement
            if (m.unitsOnMap[i].FactionTeam == "Red")                       
            {
                m.unitMove(m.unitsOnMap[i], currentX - 1, currentY);
            }
            else if (m.unitsOnMap[i].FactionTeam == "Blue")               
            {
                m.unitMove(m.unitsOnMap[i], currentX + 1, currentY);
            }
            else if (m.unitsOnMap[i].FactionTeam == "Neutral")         
            {
                m.unitMove(m.unitsOnMap[i], currentX + 1, currentY);
            }
            #endregion

            #region Unit move to nearest Unit                             
            if (closestUnit != null)
            {
                if (m.unitsOnMap[i].XPosition < closestUnit.XPosition)
                {
                    m.unitMove(m.unitsOnMap[i], currentX + 1, currentY);
                }
                if (m.unitsOnMap[i].XPosition > closestUnit.XPosition)
                {
                    m.unitMove(m.unitsOnMap[i], currentX - 1, currentY);
                }

                if (m.unitsOnMap[i].YPosition < closestUnit.YPosition)
                {
                    m.unitMove(m.unitsOnMap[i], currentX, currentY + 1);
                }
                if (m.unitsOnMap[i].YPosition > closestUnit.YPosition)
                {
                    m.unitMove(m.unitsOnMap[i], currentX, currentY - 1);
                }

                if (m.unitsOnMap[i].isEnemyInRange(closestUnit))
                {
                    m.unitsOnMap[i].combat(closestUnit);
                    m.checkHealth();
                    m.checkHealth();
                }
                if (m.unitsOnMap[i].Health < 25)
                {
                    m.unitsOnMap[i].move(m.unitsOnMap[i].XPosition, m.unitsOnMap[i].YPosition);
                }
            }
            #endregion
        }

        #region Map Methods
        public void GEinitialiseMap()
        {
            m.initialiseMap();
        }

        public void GEbattlefield()
        {
            m.battlefield();
        }

        public string GEredraw()
        {
            return m.redraw();
        }

        public int GElistUnitsOnMapCount()
        {
            return m.unitsOnMap.Count;
        }

        public string GEtoString(int i)
        {

            return m.unitsOnMap[i].toString();

        }
        #endregion

    }
}
