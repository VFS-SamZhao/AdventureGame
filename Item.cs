//Copyright (C) 2020 SamZhao, All Right Reserved
using System;

namespace Adventure
{
    class Item
    {
        private int Itemid;
        private string ItemDe;//Item description
        private bool discovered;

        public Item( int id, string desc )
        {
            ItemDe = desc;
            Itemid = id;
            discovered = false;
        }

        public void acquired()
        {
            if(discovered)
            {
                Console.WriteLine("The space is entirely empty, you have that item stored in your bag already.");
            }
            discovered = true;
        }

        public void unacquired()
        {
            discovered = false;
        }

        public void itemDescribe()
        {
            //output the description for the item player selected
            Console.WriteLine(ItemDe);
        }

    }
}