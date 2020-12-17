using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kursy.Models
{
    public class GiveAchievement
    {
        public void GiveAchievments(int achievCount, List<int> arr1, List<int> arr2, Human teacher, Human child)
        {
            Random rand = new Random();
            for (int i = 0; i < achievCount; i++)
            {
                int achieve = rand.Next(1, 3);

                if (achieve == (int)teacher)
                {
                    arr1.Add(1);
                }

                if (achieve == (int)child)
                {
                    arr2.Add(2);
                }
            }
        }
    }
}