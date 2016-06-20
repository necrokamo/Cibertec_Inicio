using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class CarController : Controller
    {
        private CarData _car = new CarData();
        // GET: Client
        public ActionResult Index()
        {
            return View(_car.GetList());
        }

        public ActionResult Create()
        {
            return View(new Car());
        }

        [HttpPost]
        public ActionResult Create(Car car)
        {
            if (ModelState.IsValid)
            {
                _car.Add(car);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            var car = _car.GetClientById(id);
            if (car == null)
            {
                return RedirectToAction("Index");
            }
            return View(car);
        }
        [HttpPost]
        public ActionResult Delete(Car car)
        {
            if (_car.Delete(car) > 0)
            {
                return RedirectToAction("Index");
            }
            return View(car);
        }

        public ActionResult Edit(int id)
        {
            var car = _car.GetClientById(id);
            if (car== null)
            {
                return HttpNotFound();
            }
            return View(car);
        }
        [HttpPost]
        public ActionResult Edit(Car car)
        {
            if (ModelState.IsValid)
            {
                _car.Update(car);
                return RedirectToAction("Index");
            }
            return View(car);
        }

        public ActionResult Details(Car car)
        {
            return View(car);
        }
    }
}