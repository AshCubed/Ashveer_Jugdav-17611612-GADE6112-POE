using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Task_3
{
    class Map
    {
        /*public void getMapSize(ref int userX, ref int userY)
        {
            userDefinedX = userX;
            userDefinedY = userY;
        }
        public static int userDefinedX = 20;
        public static int userDefinedY = 20;*/

        public string [,] map = new string[20, 20];
        public List<Unit> unitsOnMap = new List<Unit>();
        public List<Building> buildingsOnMap = new List<Building>();


        public void initialiseMap()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    map[i, j] = ".";
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

        public void constructBuildings()
        {
            Random rnd = new Random();

            Building resouceBuilding = new ResourceBuilding(17, 17, 100, "Red", "$", "something", 10, 50);
            map[resouceBuilding.XPosition, resouceBuilding.YPosition] = resouceBuilding.SymbolImage;
            buildingsOnMap.Add(resouceBuilding);

            Building factoryBuilding = new FactoryBuilding(1, 1, 100, "Blue", "@", 55, 50, 50);
            map[factoryBuilding.XPosition, factoryBuilding.YPosition] = factoryBuilding.SymbolImage;
            buildingsOnMap.Add(factoryBuilding);

            Building gatewayBuilding = new GatewayBuilding(rnd.Next(0, (18)), rnd.Next(0, (18)), 100, "none", "%");
            map[gatewayBuilding.XPosition, gatewayBuilding.YPosition] = gatewayBuilding.SymbolImage;
            buildingsOnMap.Add(gatewayBuilding);
        }


        public void battlefield()
        {
            int numberOfUnits = 0;
            int size = 30; 
            Random rnd = new Random();

            if (numberOfUnits < size)
            {
                if (map[buildingsOnMap[0].XPosition - 1, buildingsOnMap[0].YPosition] == "." && map[buildingsOnMap[1].XPosition + 1, buildingsOnMap[1].YPosition] == ".")
                {
                    int unitSelection = rnd.Next(1, 100);
                    int teamSelection = rnd.Next(1, 100);

                    if ((unitSelection) % 2 == 0)
                    {
                        if ((teamSelection) % 2 == 0)
                        {
                            Unit tmp = new MeleeUnit(buildingsOnMap[0].XPosition - 1, buildingsOnMap[0].YPosition, 100, 1, false, 18, "Red", "M", "Joe");
                            map[tmp.XPosition, tmp.YPosition] = tmp.SymbolImage;
                            unitsOnMap.Add(tmp);
                            numberOfUnits++;
                        }
                        else
                        {
                            Unit tmp = new MeleeUnit(buildingsOnMap[1].XPosition + 1, buildingsOnMap[1].YPosition, 100, 1, false, 18, "Blue", "m", "Connor");
                            map[tmp.XPosition, tmp.YPosition] = tmp.SymbolImage;
                            unitsOnMap.Add(tmp);
                            numberOfUnits++;
                        }
                    }
                    else
                    {
                        if ((teamSelection) % 2 == 0)
                        {
                            Unit tmp = new RangedUnit(buildingsOnMap[0].XPosition - 1, buildingsOnMap[0].YPosition, 100, 1, false, 19, "Red", "R", "shalom");
                            map[tmp.XPosition, tmp.YPosition] = tmp.SymbolImage;
                            unitsOnMap.Add(tmp);
                            numberOfUnits++;
                        }
                        else
                        {
                            Unit tmp = new RangedUnit(buildingsOnMap[1].XPosition + 1, buildingsOnMap[1].YPosition, 100, 1, false, 19, "Blue", "r", "bob");
                            map[tmp.XPosition, tmp.YPosition] = tmp.SymbolImage;
                            unitsOnMap.Add(tmp);
                            numberOfUnits++;
                        }
                    }

                    Unit n = new NeutralUnit(rnd.Next(0, 18), rnd.Next(0, 18), 100, 1, false, 19, "Neutral", "N", "mushi mush");
                    map[n.XPosition, n.YPosition] = n.SymbolImage;
                    unitsOnMap.Add(n);
                    numberOfUnits++;
                }
            }
        }



        public void unitMove(Unit u, int newX, int newY)
        {
            map[(u.XPosition), (u.YPosition)] = ".";
            unitUpdate(u, newX, newY);
            map[(u.XPosition), (u.YPosition)] = u.SymbolImage;
        }

        private void unitUpdate(Unit u, int newX, int newY)
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



        public void inGameEvent()
        {
            foreach (Unit u in unitsOnMap)
            {
                if (u.FactionTeam == "Red" && u.SymbolImage == "M")
                {
                    u.FactionTeam = "Blue";
                    u.SymbolImage = "m";
                    map[u.XPosition, u.YPosition] = u.SymbolImage;
                }
                else if (u.FactionTeam == "Red" && u.SymbolImage == "R")
                {
                    u.FactionTeam = "Blue";
                    u.SymbolImage = "r";
                    map[u.XPosition, u.YPosition] = u.SymbolImage;
                }
                else if (u.FactionTeam == "Blue" && u.SymbolImage == "m")
                {
                    u.FactionTeam = "Red";
                    u.SymbolImage = "M";
                    map[u.XPosition, u.YPosition] = u.SymbolImage;
                }
                else if (u.FactionTeam == "Blue" && u.SymbolImage == "r")
                {
                    u.FactionTeam = "Red";
                    u.SymbolImage = "R";
                    map[u.XPosition, u.YPosition] = u.SymbolImage;
                }
            }

            foreach (Building b in buildingsOnMap)
            {
                if (b.FactionTeam == "Red" && b.SymbolImage == "$")
                {
                    Debug.WriteLine("BUILDING MOVE1");
                    b.FactionTeam = "Blue";
                    b.SymbolImage = "@";
                    map[b.XPosition, b.YPosition] = b.SymbolImage;
                }
                else if (b.FactionTeam == "Blue" && b.SymbolImage == "@")
                {
                    Debug.WriteLine("BUILDING MOVE2");
                    b.FactionTeam = "Red";
                    b.SymbolImage = "$";
                    map[b.XPosition, b.YPosition] = b.SymbolImage;
                }
            }
        }

        public void save()
        {
            foreach (Building b in buildingsOnMap)
            {
                b.save();
            }
            foreach (Unit u in unitsOnMap)
            {
                u.save();
            }
        }

        public void readMeleeUnit()
        {
            FileStream inFile = null;
            StreamReader reader = null;
            string input;
            int xPosition;
            int yPosition;
            int health;
            int speed;
            bool attack;
            int attackRange;
            string factionTeam;
            string symbolImage;
            string name;

            try
            {
                inFile = new FileStream(@"Files\MeleeUnit.txt", FileMode.Open, FileAccess.Read);
                reader = new StreamReader(inFile);
                input = reader.ReadLine();      
                while (input != null)
                {
                    xPosition = int.Parse(input);
                    yPosition = int.Parse(reader.ReadLine());
                    health = int.Parse(reader.ReadLine());
                    speed = int.Parse(reader.ReadLine());
                    attack = bool.Parse(reader.ReadLine());
                    attackRange = int.Parse(reader.ReadLine());
                    factionTeam = (reader.ReadLine());
                    symbolImage = (reader.ReadLine());
                    name = (reader.ReadLine());

                    Unit tmp = new MeleeUnit(xPosition, yPosition, health, speed, attack, attackRange, factionTeam, symbolImage, name);
                    map[tmp.XPosition, tmp.YPosition] = tmp.SymbolImage;
                    unitsOnMap.Add(tmp);

                    input = reader.ReadLine();
                }
                reader.Close();
                inFile.Close();
            }
            catch (Exception fe)
            {
                Debug.WriteLine(fe.Message);
            }
            finally
            {
                if (inFile != null)
                {
                    reader.Close();
                    inFile.Close();
                }
            }
        }

        public void readRangedUnit()
        {
            FileStream inFile = null;
            StreamReader reader = null;
            string input;
            int xPosition;
            int yPosition;
            int health;
            int speed;
            bool attack;
            int attackRange;
            string factionTeam;
            string symbolImage;
            string name;

            try
            {
                inFile = new FileStream(@"Files\RangedUnit.txt", FileMode.Open, FileAccess.Read);
                reader = new StreamReader(inFile);
                input = reader.ReadLine();  
                while (input != null)
                {
                    xPosition = int.Parse(input);
                    yPosition = int.Parse(reader.ReadLine());
                    health = int.Parse(reader.ReadLine());
                    speed = int.Parse(reader.ReadLine());
                    attack = bool.Parse(reader.ReadLine());
                    attackRange = int.Parse(reader.ReadLine());
                    factionTeam = (reader.ReadLine());
                    symbolImage = (reader.ReadLine());
                    name = (reader.ReadLine());

                    Unit tmp = new RangedUnit(xPosition, yPosition, health, speed, attack, attackRange, factionTeam, symbolImage, name);
                    map[tmp.XPosition, tmp.YPosition] = tmp.SymbolImage;
                    unitsOnMap.Add(tmp);

                    input = reader.ReadLine();    
                }
                reader.Close();
                inFile.Close();
            }
            catch (Exception fe)
            {
                Debug.WriteLine(fe.Message);
            }
            finally
            {
                if (inFile != null)
                {
                    reader.Close();
                    inFile.Close();
                }
            }
        }

        public void readResourceBuilding()
        {
            FileStream inFile = null;
            StreamReader reader = null;
            string input;
            int xPosition;
            int yPosition;
            int health;
            string factionTeam;
            string symbolImage;
            string resourceType;
            int resourcesPerGameTick;
            int resourcesRemaining;

            try
            {
                inFile = new FileStream(@"Files\ResourceBuilding.txt", FileMode.Open, FileAccess.Read);
                reader = new StreamReader(inFile);
                input = reader.ReadLine();   
                while (input != null)
                {
                    xPosition = int.Parse(input);
                    yPosition = int.Parse(reader.ReadLine());
                    health = int.Parse(reader.ReadLine());
                    factionTeam = (reader.ReadLine());
                    symbolImage = (reader.ReadLine());
                    resourceType = (reader.ReadLine());
                    resourcesPerGameTick = int.Parse(reader.ReadLine());
                    resourcesRemaining = int.Parse(reader.ReadLine());

                    Building tmp = new ResourceBuilding(xPosition, yPosition, health, factionTeam, symbolImage, resourceType, resourcesPerGameTick, resourcesRemaining);
                    map[tmp.XPosition, tmp.YPosition] = tmp.SymbolImage;
                    buildingsOnMap.Add(tmp);

                    input = reader.ReadLine();     
                }
                reader.Close();
                inFile.Close();
            }
            catch (Exception fe)
            {
                Debug.WriteLine(fe.Message);
            }
            finally
            {
                if (inFile != null)
                {
                    reader.Close();
                    inFile.Close();
                }
            }
        }

        public void readFactoryBuilding()
        {
            FileStream inFile = null;
            StreamReader reader = null;
            string input;
            int xPosition;
            int yPosition;
            int health;
            string factionTeam;
            string symbolImage;
            int unitsToProduce;
            int gameTicksPerProduction;
            int spawnPoint;

            try
            {
                inFile = new FileStream(@"Files\FactoryBuilding.txt", FileMode.Open, FileAccess.Read);
                reader = new StreamReader(inFile);
                input = reader.ReadLine();    
                while (input != null)
                {
                    xPosition = int.Parse(input);
                    yPosition = int.Parse(reader.ReadLine());
                    health = int.Parse(reader.ReadLine());
                    factionTeam = (reader.ReadLine());
                    symbolImage = (reader.ReadLine());
                    unitsToProduce = int.Parse(reader.ReadLine());
                    gameTicksPerProduction = int.Parse(reader.ReadLine());
                    spawnPoint = int.Parse(reader.ReadLine());

                    Building tmp = new FactoryBuilding(xPosition, yPosition, health, factionTeam, symbolImage, unitsToProduce, gameTicksPerProduction, spawnPoint);
                    map[tmp.XPosition, tmp.YPosition] = tmp.SymbolImage;
                    buildingsOnMap.Add(tmp);

                    input = reader.ReadLine();     
                }
                reader.Close();
                inFile.Close();
            }
            catch (Exception fe)
            {
                Debug.WriteLine(fe.Message);
            }
            finally
            {
                if (inFile != null)
                {
                    reader.Close();
                    inFile.Close();
                }
            }
        }

        public string detailsString(int x, int y)
        {
            foreach (Unit u in unitsOnMap)
            {
                if (u.XPosition == x && u.YPosition == y)
                {
                    return u.toString();
                }
            }
            return null;
        }

    }
}
