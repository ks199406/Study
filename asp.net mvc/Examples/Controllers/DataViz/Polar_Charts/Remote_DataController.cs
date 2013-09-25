﻿using System;
using System.Linq;
using System.Web.Mvc;
using Domas.Web.Mvc.Examples.Models;

namespace Domas.Web.Mvc.Examples.Controllers
{
    public partial class Polar_ChartsController : Controller
    {
        public ActionResult Remote_Data()
        {
            return View();
        }

        public ActionResult _AntennaGain()
        {
            return Json(ChartDataRepository.AntennaGain());
        }
    }
}