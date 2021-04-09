﻿using GildedRose.Console.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console.Dal
{
    public class ItemsStorage
    {
      public List<Item> GetItems()
        {
            var items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item
                     {
                      Name = "Backstage passes to a TAFKAL80ETC concert",
                      SellIn = 15,
                      Quality = 20
                      },
               new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };

            return items;
        }
    }
}
