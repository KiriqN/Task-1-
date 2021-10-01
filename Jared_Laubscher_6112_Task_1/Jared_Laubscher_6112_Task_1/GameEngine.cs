using System;
using System.Collections.Generic;
using System.Text;
using static Jared_Laubscher_6112_Task_1.Character;


namespace Jared_Laubscher_6112_Task_1
{

        class GameEngine
        {



            private Map maptiles = new Map(20, 20, 20, 20, 5);

            private Hero hero { get; set; }

            public Map MapTiles
            {
                get { return maptiles; }
                set { maptiles = value; }
            }

            public override string ToString()
            {
                string field = "......................... \n" +
                               "......................... \n" +
                               "......................... \n" +
                               "......................... \n" +
                               "............H......... \n" +
                               "......................... \n" +
                               "......................... \n" +
                               "......................... \n" ;

                for (int j = 0; j < MapTiles.MapWidth; j++)
                {
                    for (int i = 0; i < MapTiles.MapHeight; i++)
                    {
                        field += MapTiles.maptiles[j, i]._Symbol + " ";
                    }


                    field += "\t";

                }
                return field;
            }

            public bool MovePlayer(Movement move)
            {
                Movement PlayerMove = MapTiles.Hero.ReturnMove(move);
                MapTiles.Hero.Move(PlayerMove);

                MapTiles.UpdateMap();

                if (PlayerMove == Movement.No_Movement)
                {

                    return true;
                }

                return false;

            }

        public string HeroInfo
        {
            get { return maptiles.Hero.ToString();}
            set { HeroInfo = value; }
        }

        }

   
}
