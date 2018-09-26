using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
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
            ge.GEinitialiseMap();
            ge.GEbattlefield();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            rtxtMap.Text = ge.GEredraw();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }


        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < ge.GElistUnitsOnMapCount(); i++)
            {
                ge.rules(i);
            }
            rtxtMap.Text = ge.GEredraw();
            lblGameTime.Text = Convert.ToString(count++);
        }

        int index = 0;

        private void btnFoward_Click(object sender, EventArgs e)
        {
            index++;
            if (index >= ge.GElistUnitsOnMapCount())
                index = ge.GElistUnitsOnMapCount() - 1;
            else
                txtUnitInfo.Text = ge.GEtoString(index);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 0)
                index = 0;
            else
                txtUnitInfo.Text = ge.GEtoString(index);
        }
    }
}
