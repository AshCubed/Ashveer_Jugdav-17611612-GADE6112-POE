using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task_2
{
    class GameEngine
    {
        private Map m = new Map();

        public int count1()
        {
            return m.unitsOnMap.Count;
        }

        public void rules(int i)
        {
            if ((i >= 0) && (i <= m.unitsOnMap.Count) && (m.unitsOnMap[i] != null))
            {
                m.checkHealth();

                #region Building Position Check
                if (m.map[m.buildingsOnMap[0].XPosition, m.buildingsOnMap[0].YPosition] == ".")
                {
                    m.map[m.buildingsOnMap[0].XPosition, m.buildingsOnMap[0].YPosition] = m.buildingsOnMap[0].SymbolImage;
                }
                if (m.map[m.buildingsOnMap[1].XPosition, m.buildingsOnMap[1].YPosition] == ".")
                {
                    m.map[m.buildingsOnMap[1].XPosition, m.buildingsOnMap[1].YPosition] = m.buildingsOnMap[1].SymbolImage;
                }
                #endregion

                int currentX = m.unitsOnMap[i].XPosition;
                int currentY = m.unitsOnMap[i].YPosition;

                Unit closestUnit = m.unitsOnMap[i].nearestUnit(m.unitsOnMap);

                #region Border Check
                if (m.unitsOnMap[i].FactionTeam == "Red")
                {
                    if (m.unitsOnMap[i].XPosition == 0)
                    {
                        m.map[m.unitsOnMap[i].XPosition, m.unitsOnMap[i].YPosition] = ".";
                        m.unitsOnMap.Remove(m.unitsOnMap[i]);
                    }
                    m.unitMove(m.unitsOnMap[i], currentX - 1, currentY);
                }
                else
                {
                    if (m.unitsOnMap[i].XPosition == 19)
                    {
                        m.map[m.unitsOnMap[i].XPosition, m.unitsOnMap[i].YPosition] = ".";
                        m.unitsOnMap.Remove(m.unitsOnMap[i]);
                    }
                    m.unitMove(m.unitsOnMap[i], currentX + 1, currentY);
                }
                #endregion

                #region Basic Movement
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
                }
                #endregion

                #region Combat
                if (closestUnit != null)
                {
                    if (m.unitsOnMap[i].isEnemyInRange(closestUnit))
                    {
                        m.unitsOnMap[i].combat(closestUnit);
                    }
                    if (m.unitsOnMap[i].Health < 25)
                    {
                        m.unitsOnMap[i].move(m.unitsOnMap[i].XPosition, m.unitsOnMap[i].YPosition);
                    }
                }
                #endregion

            }

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

        public void GEconstructBuildings()
        {
            m.constructBuildings();
        }

        public void GEsave()
        {
            m.save();
        }

        public void GEread()
        {
            m.readMeleeUnit();
            m.readRangedUnit();
            m.readResourceBuilding();
            m.readFactoryBuilding();
        }

        public int GElistUnitsOnMapCount()
        {
            return m.unitsOnMap.Count;
        }

        public string GEtoString(int i)
        {

            return m.unitsOnMap[i].toString();

        }
        #endregion*/
    }
}
