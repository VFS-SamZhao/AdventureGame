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
        public int Row {get {return _row;}}
        public int Col {get {return _col;}}
        
        //constructor(s)
        public Player( string name = "Adventurer")
        {
            _name = name;

            _row = 2;
            _col = 0;
            InitStats();
        }

        public Player(string name = "Adventurer", int row = 0, int col= 0)
        {
            _name = name;
            _row = row;
            _col = col;
            InitStats();
        }

        private void InitStats()
        {
            San = 50;
            Detect = 50;
            Intelligence = 50;
            Dexterity = 50;
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

        public Player GoSouth()
        {
            _row++;
            if (_row > 4) _row = 4;
            return this;
        }

        public  Player GoEast()
        {
            _col++;
            if(_col > 3) _col = 3;
            return this;
        }

        public Player GoWest()
        {
            _col--;
            if(_col <0) _col = 0;
            return this;
        }

    }
}