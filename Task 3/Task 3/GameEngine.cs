using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task_3
{
    class GameEngine
    {
        private static Map m = new Map();

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
                if (m.map[m.buildingsOnMap[2].XPosition, m.buildingsOnMap[2].YPosition] == ".")
                {
                    m.map[m.buildingsOnMap[2].XPosition, m.buildingsOnMap[2].YPosition] = m.buildingsOnMap[2].SymbolImage;
                }
                #endregion

                int currentX = m.unitsOnMap[i].XPosition;
                int currentY = m.unitsOnMap[i].YPosition;

                Unit closestUnit = m.unitsOnMap[i].nearestUnit(m.unitsOnMap);

                #region GateWay Rules
                if ((m.unitsOnMap[i].XPosition == m.buildingsOnMap[2].XPosition) && (m.unitsOnMap[i].YPosition == m.buildingsOnMap[2].YPosition))
                {
                    Random rnd = new Random();
                    m.unitsOnMap[i].XPosition = rnd.Next(0, 19);
                    m.unitsOnMap[i].YPosition = rnd.Next(0, 19);
                }
                #endregion

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
                    }
                    if (m.unitsOnMap[i].Health < 25)
                    {
                        m.unitsOnMap[i].move(m.unitsOnMap[i].XPosition, m.unitsOnMap[i].YPosition);
                    }
                }
            }
            #endregion

            #region Combat
            /*if (m.unitsOnMap[i].isEnemyInRange(closestUnit))
            {
                m.unitsOnMap[i].combat(closestUnit);
                m.checkHealth();
                //closestUnit = m.unitsOnMap[i].nearestUnit(m.unitsOnMap);
            }
            if (m.unitsOnMap[i].Health < 25)
            {
                m.unitsOnMap[i].move(m.unitsOnMap[i].XPosition, m.unitsOnMap[i].YPosition);
            }*/
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

        public void GEinGameEvent()
        {
            m.inGameEvent();
        }

        /*public void GEgetMapSize(int userX, int userY)
        {
            m.getMapSize(ref userX, ref userY);
        }*/

        public string GEtoString(int i)
        {

            return m.unitsOnMap[i].toString();

        }

        public int GElistUnitsOnMapCount()
        {
            return m.unitsOnMap.Count;
        }
    }
    #endregion*/
}
