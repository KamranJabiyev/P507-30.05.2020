using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelMigration.DAL;
using ModelMigration.Models;
using ModelMigration.ViewModels;

namespace ModelMigration.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            ViewBag.Username = "Kamran";
            ViewBag.Surname = "Jabiyev";
            //ViewBag.Students = students;
            List<Student> students = new List<Student>()
            { 
                new Student{Id=1,Name="Mubush",Surname="Memmedzade"},
                new Student{Id=2,Name="Gunel",Surname="Memmedova"},
                new Student{Id=3,Name="Abulfat",Surname="Memmedov"}
            };

            string[] names =
            {
                "Rauf",
                "Nigar",
                "Fazil"
            };

            int[] numbers = { 507, 508, 509, 510 };

            HomeVM model = new HomeVM()
            {
                Students = students,
                Names = names,
                Numbers= numbers
            };
            

            return View(model);
        }
    }
}