using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FootBallLeagueMVC.Models;

namespace FootBallLeagueMVC.Controllers
{
    public class AddController : Controller
    {
        // GET: Add
        public ActionResult AddRecords()
        {
            return View();
        }

        public ActionResult Index(FootBallLeague league)
        {
            FootBallLeagueDBContext dBContext = new FootBallLeagueDBContext();
            List<FootBallLeague> records = dBContext.leagues.Where(rec => rec.Status == league.Status).ToList();
            return View(records);
        }

        [HttpPost]
        public ActionResult AddRecords(FootBallLeague league)
        {
            if(ModelState.IsValid)
            {
                FootBallRepository repository = new FootBallRepository();
                repository.AddLeagueDetails(league);
                ViewBag.Message = "Match Records succesfully saved";

                return View();
            }
            ViewBag.Message = "Something went wrong ...";
            return View();
        }
    }
}