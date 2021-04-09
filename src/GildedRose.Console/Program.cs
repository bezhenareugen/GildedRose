using GildedRose.Console.Dal;
using GildedRose.Console.Entities;
using System.Collections.Generic;
using System;
using GildedRose.Console.Bll;

namespace GildedRose.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            var updateQuality = new UpdateQuality();

            var updatedItems =  updateQuality.UpdateQualityMethod();

          
            foreach (var item in updatedItems)
            {
                System.Console.WriteLine(item.Name + " | " + item.SellIn + " | " + item.Quality);
            }

            System.Console.ReadKey();

        }
    }
}
