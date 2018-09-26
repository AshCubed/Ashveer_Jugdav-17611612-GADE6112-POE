using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Task_2
{
    internal partial class Form1 : Form
    {
        private GameEngine ge = new GameEngine();

        public Form1()
        {
            InitializeComponent();
        } 

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like to load your previous game?", "Load", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ge.GEinitialiseMap();
                ge.GEread();
                timer1.Start();
                rtxtMap.Text = ge.GEredraw();
            }
            else if (result == DialogResult.No)
            {
                ge.GEinitialiseMap();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ge.GEconstructBuildings();
            timer1.Start();
            rtxtMap.Text = ge.GEredraw();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (File.Exists(@"D:\VEGA\Vega - Year 1 Semester 2\Game Development 1B\ASSIGNMENT WORK\Task 3\Task 3\bin\Debug\Files\MeleeUnits.txt"))
                {
                    File.Delete(@"D:\VEGA\Vega - Year 1 Semester 2\Game Development 1B\ASSIGNMENT WORK\Task 3\Task 3\bin\Debug\Files\MeleeUnits.txt");
                }
                if (File.Exists(@"D:\VEGA\Vega - Year 1 Semester 2\Game Development 1B\ASSIGNMENT WORK\Task 3\Task 3\bin\Debug\Files\RangedUnits.txt"))
                {
                    File.Delete(@"D:\VEGA\Vega - Year 1 Semester 2\Game Development 1B\ASSIGNMENT WORK\Task 3\Task 3\bin\Debug\Files\RangedUnits.txt");
                }
                if (File.Exists(@"D:\VEGA\Vega - Year 1 Semester 2\Game Development 1B\ASSIGNMENT WORK\Task 3\Task 3\bin\Debug\Files\FactoryBuilding.txt"))
                {
                    File.Delete(@"D:\VEGA\Vega - Year 1 Semester 2\Game Development 1B\ASSIGNMENT WORK\Task 3\Task 3\bin\Debug\Files\FactoryBuilding.txt");
                }
                if (File.Exists(@"D:\VEGA\Vega - Year 1 Semester 2\Game Development 1B\ASSIGNMENT WORK\Task 3\Task 3\bin\Debug\Files\ResourceBuilding.txt"))
                {
                    File.Delete(@"D:\VEGA\Vega - Year 1 Semester 2\Game Development 1B\ASSIGNMENT WORK\Task 3\Task 3\bin\Debug\Files\ResourceBuilding.txt");
                }
                ge.GEsave();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }


        int count = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            ge.GEbattlefield();
            rtxtMap.Text = ge.GEredraw();
            for (int i = 0; i < ge.count1(); i++)
            {
                ge.rules(i);
            }
            lblGameTime.Text = Convert.ToString(count++);
        }

        int index = 0;
        private void btnBackWard_Click(object sender, EventArgs e)
        {
            index++;
            if (index >= ge.GElistUnitsOnMapCount())
                index = ge.GElistUnitsOnMapCount() - 1;
            else
                txtUnitInfo.Text = ge.GEtoString(index);
        }

        private void btnFoward_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 0)
                index = 0;
            else
                txtUnitInfo.Text = ge.GEtoString(index);
        }
    }
}
