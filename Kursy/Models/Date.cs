using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kursy.Models
{
    public class Date
    {
        public int SumTeacher;
        public int SumChild;
        public List<int> ArrChild = new List<int>();
        public List<int> ArrTeacher = new List<int>();
        public void DateAchievments(int date, List<int> arr1, List<int> arr2)
        {
            for (int i = 0; i < arr1.Count && i < arr2.Count; i++)
            {
                ArrChild.Add(arr1[i]);
                ArrTeacher.Add(arr2[i]);
            }
        }
    }
}