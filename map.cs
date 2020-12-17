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
        private Location _theVoid;
        //Constructors
        public Map(int mapSize )
        {

            _theVoid = new Location ("The void",
            "You are in a dark space, it's black as far as you can see."+
            "You can travel as far as you want in any direction, it all looks the sam.");

            if (mapSize <1)
            return;

            _theMap = new Location[ mapSize, mapSize];
            Init();

        }

        //public methods
        public void Init()
        {
            _theMap[0,0] = (new Location( 1, "Home" ))
                .AllowGo (Direction.EAST)
                .AllowGo (Direction.SOUTH)
                .visit()
                .Describe();
                
            _theMap[0,1] = new Location( 2, "Home, 2nd floor" );
            _theMap[0,2] = new Location( 3, "Jonathan's living room" );
            _theMap[1,0] = new Location( 4, "The library" );
            _theMap[1,1] = new Location( 5, "The archieve" );
            _theMap[2,0] = new Location( 6, "The petshop" );
            _theMap[2,1] = new Location( 7, "The garden of the petshop" );
            _theMap[3,0] = new Location( 8, "Amily's House" );
            _theMap[3,1] = new Location( 9, "The hidden basement" );
            _theMap[3,2] = new Location( 10, "The living room" );
            
        }

        public Location At(int row, int col)
        {
                if ((row < 0)||(row >= mapSize)||(col < 0)||(col >= mapSize))
                    return theVoid;

            return _theMap [row, col];
        }
    }
}