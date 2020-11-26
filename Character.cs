//Copyright (C) 2020 SamZhao, All Right Reserved
using System;

namespace Adventure
{
    //Including friendly characters and enemies
    class Character
    {
        string CharaName;
        float CharaImpression;
        int CharaLives;

        public Character( string Name, float impression, int lives)
        {
            //build Characters' status 
            Name = CharaName;
            impression = CharaImpression;
            lives = CharaLives;
        }

        public void impressionLimit()
        {
            if (CharaImpression > 1)
            {
                CharaImpression =- 0.1f;
            }
            else if (CharaImpression < 0)
            {
                CharaImpression =+ 0.1f;
            }
        }

        public void FirstEncounter()
        {
            Console.WriteLine(CharaName);
        }
    }
}