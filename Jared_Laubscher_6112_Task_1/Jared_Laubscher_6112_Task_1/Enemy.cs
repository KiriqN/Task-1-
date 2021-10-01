using System;
using System.Collections.Generic;
using System.Text;

namespace Jared_Laubscher_6112_Task_1
{
   public abstract class Enemy : Character
    {
        Random rnd = new Random();
        
        public Enemy(int _X, int _Y, int _HP, int _MaxHP, int _Damage, string _Symbol ) : base(_X, _Y, _Symbol )
        {
            this.X = _X;
            this.Y = _Y;
            this.HP = _HP;
            this.MaxHP = _MaxHP;
            this.Damage = _Damage;
            this.symbol = _Symbol;
        }

        public override string ToString()
        {
            return "Enemy" + " at " + this._X + this._Y + this._Damage;
        }
    }
}
