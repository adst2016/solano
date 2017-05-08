using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Solano.Web.Areas.Main.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdministrationController : Controller
    {
        // GET: Administration/Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FormList()
        {
            return View();
        }
        
        public ActionResult PanelList()
        {
            return View();
        }

        // GET: Administration/Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administration/Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Administration/Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Administration/Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Administration/Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Administration/Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
