using GildedRose.Console.Dal;
using GildedRose.Console.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console.Bll
{
    class UpdateQuality
    {
        public List<Item> UpdateQualityMethod()
        {
            List<Item> Items = new ItemsStorage().GetItems();

            var updatedItems = new List<Item>();

            var methods = new UpdateQulityMethods();


            foreach (var item in Items)
            {
                switch (item.Name)
                {
                    case "Aged Brie":
                        methods.UpdateAgeBrieQuality(item);
                        break;
                    case "Sulfuras, Hand of Ragnaros":
                        methods.UpdateSulfarusQuality(item);
                        break;
                    case "Backstage passes to a TAFKAL80ETC concert":
                        methods.UpdateBackStageQuality(item);
                        break;
                    case "Conjured Mana Cake":
                        methods.UpdateConjuredItem(item);
                        break;
                    default:
                        methods.UpdateCommonItem(item);
                        break;
                }

                updatedItems.Add(item);

            }

            return updatedItems;
        }
    }
}
