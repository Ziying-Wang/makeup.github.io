using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Project.Models;

namespace MVC_Project.Controllers
{
    public class OptionController : Controller
    {
        // GET: Option
        public ActionResult Index()
        {
            Option daily = new Option()
            {
                type = "Daily Ticket",
                price = "64.99",
                description = "",
                img = @"daily.png"
            };

            Option season = new Option()
            {
                type = "Season Pass",
                price = "79.99",
                description = "",
                img = @"season.png"
            };

            Option membership = new Option()
            {
                type = "Six Flags Membership",
                price = "6.99 per month",
                description = "",
                img = @"membership.png"
            };

            List<Option> option = new List<Option>();
            option.Add(daily);
            option.Add(season);
            option.Add(membership);

            return View(option);
        }
    }
}