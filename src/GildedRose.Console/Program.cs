using GildedRose.Console.Dal;
using GildedRose.Console.Entities;
using System.Collections.Generic;
using System;
using GildedRose.Console.Bll;

namespace GildedRose.Console
{
    class Program
    {

        private readonly IItemStorage _itemStorage;
        private readonly IUpdateQuality _updateQuality;

        public Program()
        {
        }

        public Program(IItemStorage itemStorage, IUpdateQuality updateQuality)
        {
            _itemStorage = itemStorage;
            _updateQuality = updateQuality;
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var app = new Program();

            var items = app._itemStorage?.GetItems();



            app._updateQuality?.UpdateQualityMethod(items);


            System.Console.ReadKey();

        }
    }

}
