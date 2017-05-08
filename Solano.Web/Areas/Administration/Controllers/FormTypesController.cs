using Infrastructure.Fundamental.Controllers;
using Solano.Web.Areas.Main.Models.DTO;
using Solano.Web.Areas.Main.Services;
using System;
using System.Net;
using System.Web.Mvc;

namespace Solano.Web.Areas.Main.Controllers
{
    public class FormTypesController : AppControllerBase
    {
        private readonly IFormTypeService formTypeService;

        public FormTypesController(IFormTypeService formTypeService)
        {
            this.formTypeService = formTypeService;
        }
        
        public ActionResult Index()
        {            
            return View(formTypeService.GetAll());
        }

        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FormTypeInfoDto formTypeInfoDto = formTypeService.GetById(id.Value);
            if (formTypeInfoDto == null)
            {
                return HttpNotFound();
            }
            return View(formTypeInfoDto);
        }

        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FormTypeCreateDto formTypeDto)
        {
            if (ModelState.IsValid)
            {
                formTypeService.Create(formTypeDto);
                return RedirectToAction("Index");
            }

            return View(formTypeDto);
        }
        
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var formTypeUpdateDto = formTypeService.GetById(id.Value);

            if (formTypeUpdateDto == null)
            {
                return HttpNotFound();
            }            

            return View(formTypeUpdateDto);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FormTypeInfoDto formTypeUpdateDto)
        {
            if (ModelState.IsValid)
            {
                formTypeService.Update(formTypeUpdateDto);
                return RedirectToAction("Index");
            }
            return View(formTypeUpdateDto);
        }
        
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FormTypeInfoDto formTypeInfoDto = formTypeService.GetById(id.Value);
            if (formTypeInfoDto == null)
            {
                return HttpNotFound();
            }
            return View(formTypeInfoDto);
        }
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            formTypeService.Delete(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
