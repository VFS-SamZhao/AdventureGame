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
        private const int MAXCHARACTERS = 9;
        private const int MAXITEMS = 8;

        private Location[] locationList = new Location[MAXLOCATIONS];
        private Character[] CharacterList = new Character[MAXCHARACTERS];
        private Item[] ItemList = new Item[MAXITEMS];
        private int currentIndex = 0;
        Location currentlocation = new Location(0, "current location");
        //MAXLOCATION = 10
        public Game()
        {
            gameOver = false;
            maxRetries = 5;
            
            InitGame();
            ItemInit();
            CharaStatusInit();
        }

        public void InitGame()
        {
            //initialize our game map of locations
            locationList[0] = new Location( 1, "Home" );
            locationList[1] = new Location( 2, "The hospital" );
            locationList[2] = new Location( 3, "The hospital, 2nd floor" );
            locationList[3] = new Location( 4, "The library" );
            locationList[4] = new Location( 5, "The petshop" );
            locationList[5] = new Location( 6, "The garden of the petshop" );
            locationList[6] = new Location( 7, "The road to Amily's house" );
            locationList[7] = new Location( 8, "Amily's House" );
            locationList[8] = new Location( 9, "The hidden basement" );
            locationList[9] = new Location( 10, "The living room" );

            currentIndex = 0;

            for (int index = 0; index < locationList.Length; index++)
            {
                locationList[index].Unvisit();
            }

        }

        public void ItemInit()
        {
            //initialize the items in the game
            ItemList[0] = new Item( 1, "Jonathan's old cat teaser wand" );
            ItemList[1] = new Item( 2, "unused medical bandage" );
            ItemList[2] = new Item( 3, "Jonathan's medical case of illness" );
            ItemList[3] = new Item( 4, "weathered book with blank cover" );
            ItemList[4] = new Item( 5, "decorated kitchen knife" );
            ItemList[5] = new Item( 6, "unknown torned key" );
            ItemList[6] = new Item( 7, "Mirror Fragment" );
            ItemList[7] = new Item( 8, "necklace" );

            for(int index4item = 0; index4item < ItemList.Length; index4item++)
            {
                ItemList[index4item].unacquired();
            }
        }

        public void CharaStatusInit()
        {
            //initialize each character's status
            CharacterList[0] = new Character( "Jonathan", 1F, 5 );
            CharacterList[1] = new Character( "Mia", 0.3F, 2 );
            CharacterList[2] = new Character( "Nancy", 0.5F, 4 );
            CharacterList[3] = new Character( "Dr.Bond", 0.2F, 4 );
            CharacterList[4] = new Character( "Old Leon", 0.2F, 5 );
            CharacterList[5] = new Character( "Finn", 0.5F, 5 );
            CharacterList[6] = new Character( "Charlotte", 0.3F, 4 );
            CharacterList[7] = new Character( "Amily", 0.1F, 8 );
            CharacterList[8] = new Character( "The Rotten Ghoul", 0F, 12 );

            //character's impression of the players will not be greater than 1, nor lesser than 0
            for (int charaNumber = 0; charaNumber < CharacterList.Length; charaNumber++)
            {
                CharacterList[charaNumber].impressionLimit();
            }

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
            Console.WriteLine("Please enter 1 to view the location list,");
            Console.WriteLine("and 2 for the current location, and 3 for moving to another location");
            //collecte user feedback, update location
            var input = Console.ReadLine();
            int selectlist = 0;
            if (!int.TryParse( input, out selectlist ))
            {
                Console.WriteLine( "Invalid Input" );
                return;
            }

            switch(selectlist)
            {
                case 1:
                    for(int listone = 0; listone < locationList.Length; listone++)
                    {
                        int number = listone + 1;
                        Console.Write(number);
                        locationList[listone].Describe();
                    }
                    break;

                case 2:
                    currentlocation.Describe();
                    break;
                
                case 3:
                    Console.WriteLine( "You may go to (1)home, (2)the hospital, and (3)the library now" );
                    var MoveInput = Console.ReadLine();
                    int selectmove = 0;
                    if (!int.TryParse( MoveInput, out selectmove ))
                    {
                        Console.WriteLine( "Invalid Input" );
                        return;
                    }
                    switch (selectmove)
                    {
                        case 1:
                            currentlocation = locationList[0];
                            Console.WriteLine( "You are at Jonathan's home now" ); 
                            break;
                        case 2:
                            currentlocation = locationList[1];
                            Console.WriteLine( "You are in the hospital now" ); 
                            break;
                        case 3:
                            currentlocation = locationList[3];
                            Console.WriteLine( "You are in the library now" ); 
                            break;
                        default:
                        Console.WriteLine( "invalid number, please enter a number within 1,2,3" );
                        break;  
                    }
                    break;

                default:
                Console.WriteLine( "Your selection is invalid, please choose again" );
                break;
            }

            
            //var selection = int.Parse( input );
            /*
            save for later use
            int selection = 0;
            if (!int.TryParse( input, out selection ))
            {
                Console.WriteLine( "Invalid Input" );
                return;
            }

            
            switch (selection)
            {
                case 1:
                case 2:
                case 3:
                    currentlocation = locationList[0];
                    Console.WriteLine( "There's no response" ); 
                    break;

                default:
                Console.WriteLine( "Your selection is invalid, please choose again" );
                break;
            }
            */

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
            //print nice stuff on screen
            
            //locationList[currentIndex].Describe();

            //print nice prompts for next user input
            
            /*
            using this in the future
            const int MAXOPTIONS = 5;
            string prompt = "Enter your next action:";

            for(int option = 0; option < MAXOPTIONS; option++)
            {
                prompt += $"({option}) Choose option ({option})";
            }

            Console.WriteLine(prompt);
            */

        }
            

    }

}