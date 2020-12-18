using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTL_LTWEB.Models;

namespace BTL_LTWEB.Controllers
{
    public class PlacesController : Controller
    {
        PlacesModel placeModel = new PlacesModel();
        // GET: Places
        public ActionResult Index()
        {
            return View(placeModel.findAllPlace());
        }
    }
}