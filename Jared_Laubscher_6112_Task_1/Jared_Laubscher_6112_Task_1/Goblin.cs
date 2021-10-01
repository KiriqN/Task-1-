using System;
using System.Collections.Generic;
using System.Text;

namespace Jared_Laubscher_6112_Task_1
{
    public class Goblin : Enemy
    {

        Movement Goblinmovement;
        public Goblin(int _X, int _Y, string _Symbol = "G") : base(_X, _Y, 10, 10, 1, _Symbol)
        {

        }

        public override Movement ReturnMove(Movement move = Movement.No_Movement)
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 4);
            if (random == 0)
            {
                Goblinmovement = Movement.Up;
            }

            if (random == 1)
            {
                Goblinmovement = Movement.Down;
            }

            if (random == 2)
            {
                Goblinmovement = Movement.Right;
            }

            if (random == 3)
            {
                Goblinmovement = Movement.Left;
            }

            if (random == 4)
            {
                Goblinmovement = Movement.No_Movement;
            }

            return Goblinmovement;


        }

        
    }
}
