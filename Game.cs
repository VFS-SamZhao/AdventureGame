//Copyright (C) 2020 SamZhao, All Right Reserved
using System;

namespace Adventure
{
    class Game
    {
        //put my attributes here
        private bool gameOver;
        private int maxRetries;
        private const int MAXLOCATIONS = 10;
        private const int MAP_SIZE = 4;

        private Map _map;
        private Player _thePlayer;

        //MAXLOCATION = 10
        public Game()
        {
            gameOver = false;
            maxRetries = 5;
            
            _thePlayer = new Player("Sam", 0, 3);

            _map = new Map( MAP_SIZE );
            
        }


        public void Run()
        {
            while(!gameOver)
            {
                //update the status of the player
                //get player input
                Update();

                //draw the descriptions on the screen
                //provide the player with options/prompts
                Render();
            }   
        }
        


        private void Update()
        {
            var input = Console.ReadLine();
            
            int selection = 0;
            var canParse = int.TryParse( input, out selection );
            if (!canParse)
            {
                Console.WriteLine( "Invalid Input" );
                return;
            }

            
            switch (selection)
            {
                case (int)Direction.NORTH:
                    _thePlayer.GoNorth();
                    break;
                case (int)Direction.SOUTH:
                    _thePlayer.GoSouth();
                    break;
                case (int)Direction.EAST:
                    _thePlayer.GoEast();
                    break;
                case (int)Direction.WEST:
                    _thePlayer.GoWest();
                    break;

                default:
                Console.WriteLine( "Your selection is invalid, please choose again" );
                break;
            }
            

            //locationList[currentIndex].visit();
            
            //maxRetries--;
            if (maxRetries < 1)
            {
                Console.WriteLine("Game Over"); 
                gameOver = true;
            }
        }
        
        private void Render()
        {          
            var row = _thePlayer.Row;
            var col = _thePlayer.Col;
            var currentlocation = _map.At(row, col);
            currentlocation.Describe();

            string prompt = "Enter your next action:";
            for(Direction d = Direction.NORTH; d <= Direction.WEST; d++)
            {
                if (currentlocation.CanGo(d))
                {
                    Console.WriteLine(prompt += $"({d}) You can go ({d})");
                }

            }
            Console.WriteLine(prompt);
        }
            

    }

}