using FlatPlanet.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace FlatPlanet.Controllers
{
    public class HomeController : Controller
    {
        private ICounterService _counterService;

        public HomeController(ICounterService counterService)
        {
            this._counterService = counterService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public int Click(int numberOfClicks)
        {
            int latestCount = this._counterService.IncreaseCount(numberOfClicks);

            return latestCount;
        }

        [HttpGet]
        public int GetLatestCount()
        {
            return this._counterService.GetLatestCount();
        }
    }
}