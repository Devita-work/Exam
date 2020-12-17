using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kursy.Models
{
    public class Teacher
    {
        public string Status
        {
            get
            {
                if (teacherAchievments.Count < 4)
                {
                    status = "Серебряный статус";
                }
                else if (teacherAchievments.Count < 6)
                {
                    status = "Золотой статус";
                }
                else
                {
                    status = "платиновый статус";
                }
                return status;
            }
        }

        public Human teacher;
        string status;
        public List<int> teacherAchievments = new List<int>();

        public Teacher(Human human)
        {
            teacher = human;
        }
    }
}