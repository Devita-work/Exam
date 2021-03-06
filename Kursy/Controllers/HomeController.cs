﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kursy.Models
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            Models.Teacher teacher = new Models.Teacher();
            Models.Child child = new Models.Child();

            Models.GiveAchievement giveAchievement = new GiveAchievement();
            Models.Achievment achievment = new Achievment();
            Models.Achievment achievment1 = new Achievment();

            Models.Achievment[] achievments = new Models.Achievment[2] { achievment, achievment1 };
            Random rand = new Random();

            achievment.WhoseAchievment = Models.AchievmentType.Teacher;

            for(int i = 0; i < 10; i++)
            {
                int index = rand.Next(0, 2);
                giveAchievement.GiveAchievment(achievments[index], teacher);
                giveAchievement.GiveAchievment(achievments[index], child);

            }

            //Models.Teacher teacher = new Models.Teacher(Models.Human.Teacher);
            //Models.Child child = new Models.Child(Models.Human.Child);

            //Random rand = new Random();

            //int achievCount = 1;
            //int date = 2;

            //while (achievCount < date)
            //{
            //    achievCount = rand.Next(1, 17); //Сколько всего ачивок

            //    date = rand.Next(1, achievCount); //До какой даты
            //}
            //Models.GiveAchievement giveAchievement = new Models.GiveAchievement();
            //giveAchievement.GiveAchievments(achievCount, teacher.teacherAchievments, child.childAchievments, teacher.teacher, child.child);
            //Models.Date dateAchievement = new Models.Date();
            //dateAchievement.DateAchievments(date, teacher.teacherAchievments, child.childAchievments);

            //ViewBag.SumChild = dateAchievement.ArrChild.Count;
            //ViewBag.SumTeacher = dateAchievement.ArrTeacher.Count;
            //ViewBag.AchieveDate = date;
            ViewBag.TeacherStat = teacher.Status;
            ViewBag.TeacherAchieve = teacher.Achievments.Count;
            ViewBag.ChildAchieve = child.Achievments.Count;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}