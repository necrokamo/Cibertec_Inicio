﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class ClientController : Controller
    {
        private ClientData _client = new ClientData();
        // GET: Client
        public ActionResult Index()
        {
            //var client = new ClientData();
            //return View(client.GetFakeData());
            return View(_client.GetList());
        }

        public ActionResult Create()
        {
            return View(new Client());
        }

        [HttpPost]
        public ActionResult Create(Client client)
        {
            if (ModelState.IsValid)
            {
                _client.Add(client);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            var client = _client.GetClientById(id);
            if (client == null)
            {
               return  RedirectToAction("Index");
            }
            return View(client);
        }
        [HttpPost]
        public ActionResult Delete(Client client)
        {            
              if(_client.Delete(client)> 0){ 
                return RedirectToAction("Index");
            }
            return View(client);
        }

        public ActionResult Edit(int id)
        {
            var client = _client.GetClientById(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }
        [HttpPost]
        public ActionResult Edit(Client client)
        {
            if (ModelState.IsValid)
            {
                _client.Update(client);
                return RedirectToAction("Index");
            }
            return View(client);
        }
    }
}