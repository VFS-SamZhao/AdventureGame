//Copyright (C) 2020 SamZhao, All Right Reserved
using System;

namespace Adventure
{
    //Usage Direction.North
    public enum Direction { NORTH, SOUTH, EAST, WEST };
    class Location
    {
        //Attributes
        int id;
        string description;
        private bool visited = false;
        //assumen element 0 = north, 1 = south, 2 = east, 3 = west
        private bool[] _adjacent = {false, false, false, false};
        public Location( int idN, string desc )
        {
            //Build Locations here
            id = idN;
            description = desc;
            visited = false;

            //reset adjacent?
        }

        public bool CanGo ( Direction d )
        {
            //usage: if (myLoc.CanGo( Direction.North))...True/False
            return _adjacent[(int)d];
        }

        public Location AllowGo ( Direction d )
        {
            _adjacent[(int)d] = true;
            return this;
        }

        public Location visit()
        {
            if(visited)
            {
                Console.WriteLine("You have been here before");
            }
            visited = true;
            return this;
        }

        public Location Unvisit()
        {
            visited = false;
            return this;
        }

        public Location Describe()
        {
            //output this location's description for the user
            Console.WriteLine(description);
            return this;
        }

        
    }
}