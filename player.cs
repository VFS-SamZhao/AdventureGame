//Copyright (C) 2020 SamZhao, All Right Reserved
using System;

namespace Adventure
{
    class Player
    {
        //attributes, variables
        private string _name = "";
        //on the map
        private int _row;
        private int _col;
        private int _health;
        //properties
        public int San { get; private set; }  
        public int Detect { get; private set; } 
        public int Intelligence { get; private set; }   
        public int Dexterity { get; private set; }    
        public int I {get {return _row;}}
        public int J {get {return _col;}}
        
        //constructor(s)
        public Player( string name = "Jeff")
        {
            _name = name;

            San = 50;
            Detect = 50;
            Intelligence = 60;
            Dexterity = 55;

            _row = 0;
            _col = 0;
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

        public Player GoNorth()
        {
            _row--;
            if (_row < 0 ) _row = 0;
            return this;
        }

    }
}