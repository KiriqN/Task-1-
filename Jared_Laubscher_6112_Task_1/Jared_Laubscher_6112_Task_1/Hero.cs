using System;
using System.Collections.Generic;
using System.Text;

namespace Jared_Laubscher_6112_Task_1
{
    public class Hero : Character
    {
        public Hero (int _X, int _Y, int _HP, int _MaxHP, int _Damage, string _Symbol ="H") : base (_X, _Y, _Symbol)
        {
            this._Damage = 2;
            this._HP = 20;
            this._MaxHP = 20;
        }

        public override string ToString()
        {
            return "Player stats: \n" +
                "HP: " + _HP + "/" + _MaxHP + "\n" +
                "Damage: " + Damage + "\n" +
                "[" + _X + " , " + _Y + " ]";
        }


        public override Movement ReturnMove(Movement move)
        {
            if (move == Movement.Up)
            {
                move = Movement.Up;
                X--;
            }

            else if (move == Movement.Down)
            {
                move = Movement.Down;
                X++;
            }

            else if (move == Movement.Right)
            {
                move = Movement.Right;
                Y++;
            }

            else if (move == Movement.Left)
            {
                move = Movement.Left;
                Y--;
            }

            else if (move == Movement.No_Movement)
            {
                move = Movement.No_Movement;


            }

            return move;
        }


    }
}

