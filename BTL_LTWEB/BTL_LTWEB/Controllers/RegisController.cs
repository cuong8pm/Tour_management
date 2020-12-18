using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTL_LTWEB.Models;

namespace BTL_LTWEB.Controllers
{
    public class RegisController : Controller
    {
        RegisModel regisModel = new RegisModel();
        // GET: Regis
        public ActionResult Index()
        {           
            return View(regisModel.findAllRegis());
        }

        
    }
}