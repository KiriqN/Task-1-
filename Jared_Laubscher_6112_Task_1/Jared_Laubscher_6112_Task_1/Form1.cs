using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Jared_Laubscher_6112_Task_1.Character;
using static Jared_Laubscher_6112_Task_1.GameEngine;

namespace Jared_Laubscher_6112_Task_1
{
    public partial class Form1 : Form
    {
        GameEngine gameengine;
        List<Enemy> enemies = new List<Enemy>();
        public Form1()
        {
            
            InitializeComponent();
            DisplayHeroStats();
            gameengine = new GameEngine();


            DisplayMap();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        public void DisplayHeroStats()
        {

            {
                PlayerStats.Text = "HP / MaxHP \n " +
                    "[X, Y] \n" +
                     "Damage \n";
                //PlayerStats.Text = gameengine.MapTiles.Hero.ToString();
            }

        }

        public void DisplayMap()
        {

            field.Text = gameengine.ToString();


        }

        public void GameUpdate()
        {
            field.Text = "";
            field.Text = gameengine.ToString();
            DisplayHeroStats();
        }

        private void field_Click(object sender, EventArgs e)
        {
            field.Text = "";
            field.Text = gameengine.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MoveDown();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void MoveRight()
        {
            gameengine.MovePlayer(Movement.Right);
            GameUpdate();
        }

        public void MoveLeft()
        {
            gameengine.MovePlayer(Movement.Left);
            GameUpdate();
        }

        public void MoveDown()
        {
            gameengine.MovePlayer(Movement.Down);
            GameUpdate();
        }

        public void MoveUp()
        {
            gameengine.MovePlayer(Movement.Up);
            GameUpdate();
        }

        private void Up_Click(object sender, EventArgs e)
        {
            MoveUp();
        }

        private void Right_Click(object sender, EventArgs e)
        {
            MoveRight();
        }

        private void Left_Click(object sender, EventArgs e)
        {
            MoveLeft();
        }
    }
}
