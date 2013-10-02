using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using App.Services;

namespace Presentacion.Mvc.Areas.Abogado.Controllers
{
    public class AbogadoController : Controller
    {
        //
        // GET: /Abogado/Abogado/
        private IServices service;

        public AbogadoController()
        {
            service = new Services();
        }
        public ActionResult Index()
        {
            ViewBag.ListaAbogados = service.GetAllAbogados();
            return View();
        }



        public ActionResult Details(int id)
        {
            return View();
        }



        public ActionResult Create()
        {
            return View();
        }



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



        public ActionResult Edit(int id)
        {
            return View();
        }


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


        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                return Json(service.DeleteAbogados(id));
            }
            catch (Exception exception)
            {

                return Json(exception.Message);
            }

        }
    }
}
