using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Map
    {
        public string [,] map = new string[20,20];
        public List<Unit> unitsOnMap = new List<Unit>();

        public int numberOfUnits = 0;
        static Random rnd = new Random();
        int size = rnd.Next(1, 50);

        public void initialiseMap()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    map[i, j] = ".  ";
                }
            }
        }

        public string redraw()
        {
            string output = "";
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    output += map[i, j].PadRight(2);
                }
                output += Environment.NewLine;
            }
            return output;
        }

        public void battlefield()
        {
            while (numberOfUnits < size)
            {
                int location1 = rnd.Next(0, 20);
                int location2 = rnd.Next(0, 20);

                if (map[location1, location2] == ".  ")
                {
                    int unitSelection = rnd.Next(1, 100);
                    int teamSelection = rnd.Next(1, 100);

                    if ((unitSelection)%2 == 0)
                    {
                        if ((teamSelection)%2 == 0)
                        {
                            Unit tmp = new MeleeUnit(location1, location2, 100, 1, false, 1, "Red", "M");
                            map[location1, location2] = tmp.SymbolImage;
                            unitsOnMap.Add(tmp);
                            numberOfUnits++;
                        }
                        else
                        {
                            Unit tmp = new MeleeUnit(location1, location2, 100, 1, false, 1, "Blue", "m");
                            map[location1, location2] = tmp.SymbolImage;    
                            unitsOnMap.Add(tmp);
                            numberOfUnits++;
                        }
                    }
                    else
                    {
                        if ((teamSelection)%2 == 0)
                        {
                            Unit tmp = new RangedUnit(location1, location2, 100, 1, false, 2, "Red", "R");
                            map[location1, location2] = tmp.SymbolImage;
                            unitsOnMap.Add(tmp);
                            numberOfUnits++;
                        }
                        else
                        {
                            Unit tmp = new RangedUnit(location1, location2, 100, 1, false, 2, "Blue", "r");
                            map[location1, location2] = tmp.SymbolImage;
                            unitsOnMap.Add(tmp);
                            numberOfUnits++;
                        }
                    }
                }
            }
        }

        public void unitMove(Unit u, int newX, int newY)
        {
            map[(u.XPosition), (u.YPosition)] = ".  ";
            unitUpdate(u, newX, newY);
            map[(u.XPosition), (u.YPosition)] = u.SymbolImage;
        }

        public void unitUpdate(Unit u, int newX, int newY)
        {
            if ((newX >= 0 && newX < 20) && (newY >= 0 && newY < 20))
            {
                u.move(newX, newY);
            }
        }

        public void checkHealth()
        {
            for (int i = 0; i < unitsOnMap.Count; i++)
            {
                if (unitsOnMap[i].isAlive())
                {
                    map[unitsOnMap[i].XPosition, unitsOnMap[i].YPosition] = ".";
                    unitsOnMap.Remove(unitsOnMap[i]);
                }
            }
        }
    }
}
