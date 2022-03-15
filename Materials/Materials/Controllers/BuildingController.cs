using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Materials.Models;

namespace Materials.Controllers
{
    public class BuildingController : Controller
    {
   
        private MaterialsEntities db = new MaterialsEntities();
        // GET: Building
        
        public ActionResult Index()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult CreateBuilding(string BuildingID)
        {
            var result = db.SPCreateBuilding(BuildingID);
            //RedirectToAction("Index");
          

            return View();

        }

    }
}