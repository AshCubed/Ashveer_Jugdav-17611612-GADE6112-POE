using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Task_2
{
    class Map
    {
        public string [,] map = new string[20,20];
        public List<Unit> unitsOnMap = new List<Unit>();
        public List<Building> buildingsOnMap = new List<Building>();

        public int numberOfUnits = 0;  
        static Random rnd = new Random();
        int size = rnd.Next(1, 50);  

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
            Building resouceBuilding = new ResourceBuilding(19, 19, 100, "Red", "$", "something", 10, 50);
            map[19, 19] = resouceBuilding.SymbolImage;
            buildingsOnMap.Add(resouceBuilding);

            Building factoryBuilding = new FactoryBuilding(0, 0, 100, "Blue", "@", 55, 50, 50);
            map[0, 0] = factoryBuilding.SymbolImage;
            buildingsOnMap.Add(factoryBuilding);
        }

        public void battlefield() 
        {
            int flip = rnd.Next(0, 2);
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
                }
            }
        }

        public void unitMove(Unit u, int newX, int newY)
        {
            map[(u.XPosition), (u.YPosition)] = ".";
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
            for (int i = 0; i < numberOfUnits; i++)
            {
                if ((i > 0) && (i < unitsOnMap.Count) && (unitsOnMap[i] != null))
                {
                    if (unitsOnMap[i].isAlive())
                    {
                        map[unitsOnMap[i].XPosition, unitsOnMap[i].YPosition] = ".";
                        unitsOnMap.RemoveAt(i);
                    }
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
                    numberOfUnits++;

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
                    numberOfUnits++;

                    input = reader.ReadLine();     
                }
                File.Delete(@"Files\RangedUnit.txt");
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
                File.Delete(@"Files\ResourceBuilding.txt");
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
                File.Delete(@"Files\FactoryBuilding.txt");
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

    }
}
