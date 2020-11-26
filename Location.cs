//Copyright (C) 2020 SamZhao, All Right Reserved
using System;

namespace Adventure
{
    class Location
    {
        //Attributes
        int id;
        string description;
        private bool visited = false;
        public Location( int idN, string desc )
        {
            //Build Locations here
            id = idN;
            description = desc;
            visited = false;
        }

        public void visit()
        {
            if(visited)
            {
                Console.WriteLine("You have been here before");
            }
            visited = true;
        }

        public void Unvisit()
        {
            visited = false;
        }

        public void Describe()
        {
            //output this location's description for the user
            Console.WriteLine(description);
        }
    }
}