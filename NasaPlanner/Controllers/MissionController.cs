using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NasaPlanner.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NasaPlanner.Controllers
{
    public class MissionController : Controller
    {
        public NasaPlannerDbContext db = new NasaPlannerDbContext();

        public IActionResult Index()
        {
            return View(db.Missions.ToList());
        }

        public IActionResult Details(int id)
        {
            var thisMission = db.Missions.FirstOrDefault(missions => missions.MissionId == id);
            var astronauts = thisMission.GetAstronauts();
            return View(astronauts);
        }

        public IActionResult Create(int days, int tasks)
        {
            var newMission = new Mission(days, tasks);
            db.Missions.Add(newMission);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
