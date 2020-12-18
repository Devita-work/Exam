using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kursy.Models
{
    public class GiveAchievement : Achievment
    {
        public void GiveAchievment(Achievment achievment, Human human) 
        { 
            if (achievment.WhoseAchievment == AchievmentType.Childe && human is Child child)
            {
                child.Achievments.Add(achievment);
            }
            if (achievment.WhoseAchievment == AchievmentType.Teacher && human is Teacher teacher)
            {
                teacher.Achievments.Add(achievment);
            }
        }
    }
}