//Copyright (C) 2020 SamZhao, All Right Reserved
using System;

namespace Adventure
{
    
    class Program
    {
        //global variables here
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Adventure. This game is still in development.");
            Console.WriteLine("Please enter 1 to view the location list,");
            Console.WriteLine("and 2 for the item list.");

            //todo: make a game
            var game = new Game();

            game.Run();
        }
    }
}
