using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTL_LTWEB.Models;
namespace BTL_LTWEB.Controllers
{
    public class TourController : Controller
    {
        Models.HVTravelDataContext db = new HVTravelDataContext();
        private Model_Tour model_tour = new Model_Tour();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tour_Page()
        {
            return View(model_tour.getAllData());
        }
        public ActionResult upDate(int ID)
        {
            return View(model_tour.getDataById(ID));
        }
        [HttpPost]
        public ActionResult upDate(int ID, FormCollection form)
        {
            TOUR tour = model_tour.getDataById(ID);
            var title = form["Title"];
            tour.Title = title;
            model_tour.update(tour);
            return this.upDate(ID);     
        }
    }
}