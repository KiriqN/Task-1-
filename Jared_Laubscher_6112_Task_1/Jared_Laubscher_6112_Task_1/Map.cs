using System;
using System.Collections.Generic;
using System.Text;
using static Jared_Laubscher_6112_Task_1.Tile;

namespace Jared_Laubscher_6112_Task_1
{

    public enum TileType
    {
        Gold,
        Enemy,
        Hero,
        Weapon,
        Item
    }
    class Map
    {
        public Tile[,] maptiles;

        private Hero hero;

        private Enemy[] enemies;

        private Random rnd = new Random();

        public Tile[,] MapTiles
        {
            get { return maptiles; }
            set { maptiles = value; }
        }

        public Hero Hero
        {
            get { return hero; }
            set { hero = value; }
        }

        public Enemy[] Enemies
        {
            get { return enemies; }
            set { enemies = value; }
        }

        public int MapWidth { get; set; }

        public int MapHeight { get; set; }

        public Map(int MinWidth, int MaxWidth, int MinHeight, int MaxHeight, int Enemies)
        {
            MapHeight = rnd.Next(MinHeight, MaxHeight);
            MapWidth = rnd.Next(MinWidth, MaxWidth);

            maptiles = new Tile[MapWidth, MapHeight];
            enemies = new Enemy[Enemies];


            FillMap();
            InitializeMap();
           
            Hero = (Hero)Create(type: TileType.Hero);
            maptiles[Hero._X, Hero._Y] = Hero;

            for (int j = 0; j < enemies.Length; j++)
            {
                enemies[j] = (Enemy)Create(type: TileType.Enemy);
                maptiles[enemies[j]._X, enemies[j]._Y] = enemies[j];
            }
            
        }


        private Tile Create(TileType type)
        {
            int _X = rnd.Next(0, MapWidth);
            int _Y = rnd.Next(0, MapHeight);

            while (maptiles[_X, _Y] is Obstacle || maptiles[_X, _Y] is Character)
            {
                _X = rnd.Next(0, MapWidth);
                _Y = rnd.Next(0, MapHeight);
            }
            if (type == TileType.Hero)
            {
                Hero = new Hero(_X, _Y, 100, 100, 2);
                return Hero;
            }
            else if (type == TileType.Enemy)
            {
                int random = rnd.Next(1, 4);
                if (random == 1)
                {
           
                      return new Goblin(_X, _Y);
                    
                }
                else if (random == 2)
                {
                    return new Goblin(_X, _Y);
                }
                else
                {
                    return new Goblin(_X, _Y);
                }
            }
            else
            {
                return new Goblin(_X, _Y);
            }

        }
        
            public void UpdateVision()
            {
                Hero.character_vision[0] = maptiles[Hero._X - 1, Hero._Y];
                Hero.character_vision[1] = maptiles[Hero._X, Hero._Y - 1];
                Hero.character_vision[2] = maptiles[Hero._X + 1, Hero._Y];
                Hero.character_vision[3] = maptiles[Hero._X, Hero._Y + 1];

                foreach (Enemy enemy in enemies)
                {
                    enemy.character_vision[0] = maptiles[enemy._X - 1, enemy._Y];
                    enemy.character_vision[1] = maptiles[enemy._X, enemy._Y - 1];
                    enemy.character_vision[3] = maptiles[enemy._X, enemy._Y + 1];
                    enemy.character_vision[2] = maptiles[enemy._X + 1, enemy._Y];
                }
            }

        private void InitializeMap()
        {
            for (int y = 0; y < MapHeight; y++)
            {
                for (int x = 0; x < MapWidth; x++)
                {
                        maptiles[x, y] = new EmptyTile(x, y, ".");
                }
            }
            GenerateOB();
        }

        public void UpdateMap()
        {
            InitializeMap();
            maptiles[Hero._X, Hero._Y] = Hero;

            foreach (Enemy enemy in enemies)
            {
                if (enemy.IsDead() == false)
                {
                    maptiles[enemy._X, enemy._Y] = enemy;
                }
            }
            UpdateMap();
        }

        public void FillMap()
        {
            for (int x = 0; x < MapWidth; x++)
            {
                for (int y = 0; y < MapHeight; y++)
                {
                    maptiles[x, y] = new EmptyTile(x, y, ".");
                }
            }
        }

        public void GenerateOB()
        {
            for (int x = 0; x < MapWidth; x++)
            {
                for (int y = 0; y < MapHeight; y++)
                {
                    if (x == 0 || y == 0 || x == MapWidth - 1 || y == MapHeight - 1)
                    {
                        maptiles[x, y] = new Obstacle(x, y, "X");
                    }
                }
            }
        }

    }


    }

