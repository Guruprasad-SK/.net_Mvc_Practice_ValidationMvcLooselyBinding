﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationInMvc.Models;


namespace ValidationInMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SubmitData(Employee emp)
        {
            if(ModelState.IsValid)
            {
                return View("SubmitData");
            }
            return View("Index");
        }
    }
}