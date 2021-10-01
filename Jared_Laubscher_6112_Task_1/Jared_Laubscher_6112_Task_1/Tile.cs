using System;
using System.Collections.Generic;
using System.Text;

namespace Jared_Laubscher_6112_Task_1
{
   public abstract class Tile
    {
        protected int X;

        protected int Y;

        protected string symbol; 

        public int _X { get; set; }

        public int _Y { get; set; }

        public string _Symbol { get; set; }

        public enum TileType {

            Hero,
            Enemy,
            Gold,
            Weapon,
            Obstacle,
            EmptyTile,
            Character,

        }

        public TileType _TileType { get; set; }

        public Tile (int _X, int _Y, string _Symbol)
        {
            X = _X;
            Y = _Y;
            symbol = _Symbol;
			
        }
        

        
    }
}

