//Copyright (C) 2020 SamZhao, All Right Reserved
using System;

namespace Adventure
{
    class Map
    {
        //Attributes
        private Location[,] _theMap;
        int mapSize = 4;

        //An empty location for errors
        private Location theVoid;
        //Constructors
        public Map(int _size )
        {

            theVoid = new Location ("The void",
            "You are in a dark space, it's black as far as you can see."+
            "You can travel as far as you want in any direction, it all looks the sam.");

            if (mapSize <1)
            return;

            _size = mapSize;
            _theMap = new Location[ mapSize, mapSize];
            Init();

        }

        //public methods
        public void Init()
        {
            _theMap[2,0] = (new Location( "Home", "Home" ))
                .AllowGo (Direction.NORTH)
                .AllowGo (Direction.SOUTH)
                .AllowGo (Direction.EAST)
                .visit()
                .Describe();
                
            _theMap[1,0] = new Location( "Ruin", "" )
                .AllowGo (Direction.NORTH)
                .AllowGo (Direction.SOUTH)
                .AllowGo (Direction.EAST)
                .visit()
                .Describe();
                
            _theMap[1,1] = new Location( "The Front Gate", "" )
                .AllowGo (Direction.NORTH)
                .AllowGo (Direction.SOUTH)
                .visit()
                .Describe();
            _theMap[0,1] = new Location( "The Great Castle", "" )
                .AllowGo (Direction.SOUTH)
                .AllowGo (Direction.EAST)
                .visit()
                .Describe();
            _theMap[0,2] = new Location( "The Rotten Garden", "" )
                .AllowGo (Direction.SOUTH)
                .AllowGo (Direction.WEST)
                .visit()
                .Describe();
            _theMap[1,2] = new Location( "The Grand Brigde", "" )
                .AllowGo (Direction.SOUTH)
                .visit()
                .Describe();
            _theMap[2,2] = new Location( "Ancient One's Throne", "" )
                .AllowGo (Direction.SOUTH)
                .visit()
                .Describe();
            _theMap[3,2] = new Location( "The End of Land", "" )
                .AllowGo (Direction.SOUTH)
                .visit()
                .Describe();
            _theMap[3,0] = new Location( "The Silent Graveyard", "" )
                .AllowGo (Direction.NORTH)
                .AllowGo (Direction.EAST)
                .visit()
                .Describe();
            _theMap[3,1] = new Location( "The Lost Chapel", "" )
                .AllowGo (Direction.WEST)
                .AllowGo (Direction.EAST)
                .visit()
                .Describe();
            
        }

        public Location At(int row, int col)
        {
            if ((row < 0)||(row >= mapSize)||(col < 0)||(col >= mapSize))
                return theVoid;

            return _theMap [row, col];
        }
    }
}