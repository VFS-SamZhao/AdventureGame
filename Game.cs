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
            
            _thePlayer = new Player("Sam");

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
                case 1:
                case 2:
                case 3:
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
            
            const int MAXOPTIONS = 5;

            var row = _thePlayer.Row();
            var col = _thePlayer.Col();
            var currentlocation = _map.At(row, col).Describe();
            currentlocation.Describe();

            string prompt = "Enter your next action:";
            for(int option = 0; option < MAXOPTIONS; option++)
            {
                prompt += $"({option}) Choose option ({option})";
            }

            Console.WriteLine(prompt);


        }
            

    }

}