using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using StarChartPro.Data;
using StarChartPro.Models;
using StarChartPro.Models.OriginModels;
using StarChartPro.Services;

namespace StarChartPro.MVC.Controllers
{
    [Authorize]
    public class OriginController : Controller
    {
        // GET: Origin
        
        //public ActionResult List(OriginListItems model)
        public ActionResult List()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new OriginService(userId);
            var model = service;

            return View(model);
            //if (!ModelState.IsValid)
            //return View(model);

            //var service = ListOriginService();

            //if (service.ListOrigin(model))
            //{
            //ViewBag.SaveResult = "";
            //return View(model);
            //}

            //ModelState.AddModelError("", "Error, Origin failed to be created.");

            //return View(model);
        }

        private OriginService CreateOriginService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new OriginService(userId);
            return service;
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OriginCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateOriginService();

            if (service.CreateOrigin(model))
            {
                return RedirectToAction("List");
            };

            return View(model);


            //if (service.CreateOrigin(model))
            /*{
                ViewBag.SaveResult = "Your Origin was established.";
                return RedirectToAction("Home");
            };*/

            /* ModelState.AddModelError("", "Error, Origin failed to be created.");*/



        }
        /*private OriginService CreateOrigin()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = OriginListItems;
            
            
        }*/


        
        /*public ActionResult Edit(int id)
        {
            var service = CreateOriginService();
            var detail =  OriginList model;
            var model = new OriginEdit
            {

            };
            return View(model);
        }*/

        /*[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, OriginEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.OriginId != id)
            {
                ModelState.AddModelError("", "Invalid ID");
                return View(model);
            }

            if (CreateOriginService().EditOrigin(model))
            {
                TempData["SaveResult"] = "Ride Stats updated";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Error editing Ride Stats");
            return View(model);
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]*/
    }
}