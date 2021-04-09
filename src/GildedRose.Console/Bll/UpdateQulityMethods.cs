using GildedRose.Console.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console.Bll
{
    public class UpdateQulityMethods
    {
        public void UpdateAgeBrieQuality(Item item)
        {
            item.SellIn--;

            if (item.Quality < 50)
            {
                item.Quality++;
            }
        }

        public void UpdateBackStageQuality(Item item)
        {
            item.SellIn--;

            if (item.Quality < 50)
            {
                if (item.SellIn < 0)
                {
                    item.Quality = 0;
                }
                else if (item.SellIn < 5)
                {
                    item.Quality += 3;
                }
                else if (item.SellIn < 10)
                {
                    item.Quality += 2;
                }
                else
                {
                    item.Quality++;
                }
            }
        }

        public void UpdateCommonItem(Item item)
        {
            item.SellIn--;

            if (item.SellIn < 0)
            {
                item.Quality -= 2;
            }
            else
            {
                item.Quality--;
            }
        }

        public void UpdateConjuredItem(Item item)
        {
            item.SellIn--;

            if (item.SellIn < 0)
            {
                item.Quality -= 4;
            }
            else
            {
                item.Quality -= 2;
            }
        }

        public void UpdateSulfarusQuality(Item item)
        {
            if (item.Quality < 80)
            {
                item.SellIn = item.SellIn;
                item.Quality = item.Quality;
            }
        }
    }
}
