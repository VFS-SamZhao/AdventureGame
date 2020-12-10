//Copyright (C) 2020 SamZhao, All Right Reserved
using System;

namespace Adventure
{
    class Map
    {
        //Attributes
        private Location[,] _theMap;

        //Constructors
        public Map(int mapSize )
        {
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
                
            _theMap[1,0] = new Location( 2, "The hospital" );
            _theMap[2,0] = new Location( 3, "The hospital, 2nd floor" );
            _theMap[0,1] = new Location( 4, "The library" );
            _theMap[0,2] = new Location( 5, "The petshop" );
            _theMap[1,2] = new Location( 6, "The garden of the petshop" );
            _theMap[0,3] = new Location( 7, "The road to Amily's house" );
            _theMap[1,3] = new Location( 8, "Amily's House" );
            _theMap[2,3] = new Location( 9, "The hidden basement" );
            _theMap[3,3] = new Location( 10, "The living room" );
            
        }

        /*public Location At( int row, int col )
        {
            
        }*/
    }
}