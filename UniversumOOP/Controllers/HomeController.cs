using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversumOOP.Models;

namespace UniversumOOP.Controllers
{
    public class HomeController : Controller
    {
        private MyDbContext DbContext = new MyDbContext();
        public ActionResult Index()
        {
            var list = DbContext.Costumers.ToList();
            //MyDbContext dbContext = new MyDbContext();
            //Costumer costumer = new Costumer
            //{
            //    Name = "Alketa Abazi",
            //    Address = "Vushtri",
            //    PhoneNo = "044 123 123",
            //    Place = "Vushtri",
            //    BirthDate = new DateTime(2000, 12, 23),
            //    Id = 0
            //};

            //DbContext.Costumers.Add(costumer);
            //DbContext.SaveChanges();

            return View("List", list);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Costumer model)
        {
            var isValid = ModelState.IsValid;
            if (isValid)
            {
                DbContext.Costumers.Add(model);
                DbContext.SaveChanges();
            }

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var costumer = DbContext.Costumers.Where(x => x.Id == id).FirstOrDefault();
            return View(costumer);
        }

        [HttpPost]
        public ActionResult Edit(Costumer model)
        {
            if (ModelState.IsValid)
            {
                var c = DbContext.Costumers.Where(x => x.Id == model.Id).FirstOrDefault();
                c.Name = model.Name;
                c.Place = model.Place;
                c.Address = model.Address;
                c.PhoneNo = model.PhoneNo;
                c.BirthDate = model.BirthDate;
                DbContext.SaveChanges();

              return  RedirectToAction("Index");
            }

            return View(model);
        }

        public ActionResult Delete(int id)
        {
            var c = DbContext.Costumers.Where(x => x.Id == id).FirstOrDefault();
            DbContext.Costumers.Remove(c);
            DbContext.SaveChanges();

            return RedirectToAction("Index");
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