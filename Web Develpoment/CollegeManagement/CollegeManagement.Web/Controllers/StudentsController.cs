﻿using Microsoft.AspNetCore.Mvc;
using CollegeManagement.Web.Models;
using CollegeManagement.Web.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
//using System.Reflection.Metadata.Ecma335;
namespace CollegeManagement.Web.Controllers;
public class StudentsController : Controller
{
    CollegeDbConext db = new CollegeDbConext();
    //List<Student> students;
    //public StudentsController()
    //{
    //    var s1 = new Student { Name = "Roshan Twayana", RollNo = 353, Contact = "98933424234", Major = "Science", Semester = "III" };
    //    var s2 = new Student { Name = "Roshan Shrestha", RollNo = 23353, Contact = "9851342434", Major = "Arts", Semester = "II" };
    //    var s3 = new Student { Name = "Samuel Gurung", RollNo = 10353, Contact = "9893389234", Major = "Education", Semester = "IV" };
    //    var s4 = new Student { Name = "Ashok Dhakal", RollNo = 34353, Contact = "981024234", Major = "Arts", Semester = "VI" };
    //    var s5 = new Student { Name = "Suju Nepal", RollNo = 89353, Contact = "9851242340", Major = "Science", Semester = "V" };
    //    var s6 = new Student { Name = "Kamal Thapa", RollNo = 10303, Contact = "9851902365", Major = "Science", Semester = "VII" };
    //    students = new() { s1, s2, s3, s4, s5, s6 };  //Render all students//return View();//add view done(Index.cshtml vanyo)
    //}
    //public IActionResult Index()  //added new view which is Details.cshtml
    //{
    //    return View(students);
    //}
    //{   
    //        CollegeDbConext db = new CollegeDbConext();
    //    var students = db.Students.ToList();
    //        return View(students);
    //}


    public IActionResult Index()
    {
        CollegeDbConext db = new CollegeDbConext();
        var students = db.Students.ToList();
        return View(students);
    }
    public IActionResult Details(int id)
    {
        var student = db.Students.Find(id);// select * from Students where Id = id
        return View(student);
    }

    public IActionResult Add()
    {
        return View();
    }

    //public IActionResult Details(int id)
    //{
    //    var student = students.Where(x => x.RollNo == id).FirstOrDefault();
    //    return View(student);
    //}
    [HttpPost]
    public IActionResult Add(Student student)
    {
        if (student == null || !ModelState.IsValid)
            return View("Error", new ErrorViewModel { RequestId = "Register Student" });

        db.Students.Add(student);
        db.SaveChanges();

        return RedirectToAction("Index");
    }
}

