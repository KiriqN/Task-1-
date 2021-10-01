using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Jared_Laubscher_6112_Task_1
{
	public abstract class Character : Tile
	{
		protected int HP;

		protected int MaxHP;

		protected int Damage;

		public int _HP { get; set; }

		public int _MaxHP { get; set; }

		protected int _Damage { get; set; }

		 
	   public Tile[] character_vision = new Tile[4];

		

		public enum Movement
		{
			No_Movement,
			Up,
			Down,
			Left,
			Right,


		}

		public Character(int _X, int _Y, string _Symbol) : base(_X, _Y, _Symbol)
		{


		}

        

        public virtual void Attack(Character Target)
		{
			Target.HP -= this.Damage;
		}

		public bool IsDead()
        {
			if (HP == 0)
            {
				return true;
            }

			else
            {
				return false;
            }
        }

		public virtual bool CheckRange(Character Target)
        {
			if (DistanceTo(Target) <= 1 && DistanceTo(Target) >= -1)
			{
				return true;
			}
			else
            {
				return false;
            }
            
        }

        private int DistanceTo(Character target)
        {
			return Math.Abs(target.X - this.X) + Math.Abs(target.Y - this.Y);
        }

		public void Move(Movement move)
        {
			if (move == Movement.Up)
            {
				Y++;
            }

			if (move == Movement.Down)
            {
				Y--;
            }

			if (move == Movement.Right)
            {
				X++;
            }

		    if (move == Movement.Left)
            {
				X--;
            }

			if (move == Movement.No_Movement)
            {

            }

        }

		public abstract Movement ReturnMove(Movement move = 0);
        

        public abstract override string ToString();

    }
}
