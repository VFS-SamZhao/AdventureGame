//Copyright (C) 2020 SamZhao, All Right Reserved
using System;

namespace Adventure
{
    
    class Program
    {
        //global variables here
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Adventure");

            //todo: make a game
            var game = new Game();

            game.Run();
        }
    }
}
