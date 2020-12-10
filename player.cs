//Copyright (C) 2020 SamZhao, All Right Reserved
using System;

namespace Adventure
{
    class Player
    {
        //attributes, variables
        private string _name = "";
        private int _health;
        public int San { get; set; }       
        //constructor(s)
        public Player()
        {
            San = 50;
        }
        //Public methods
        //<accessibility> <return type> <Name>( parameter )
        public int GetHealth()
        {
            return _health;
        }

        public void SetHealth( int value )
        {
            _health = value;
            if (value< 0)
            {
                _health = 0;
            }
            if (value > 100)
            {
                _health = 100;
            }
        }
    }
}