using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kursy.Models
{
    public class Teacher : Human
    {
        public string Status
        {
            get
            {
                if (Achievments.Count < 4)
                {
                    status = "Серебряный статус";
                }
                else if (Achievments.Count < 6)
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

        
        string status;

        //public Teacher(Human human)
        //{
        //    teacher = human;
        //}
    }
}