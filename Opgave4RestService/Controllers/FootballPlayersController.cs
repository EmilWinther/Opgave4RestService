using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootBallLib;
using Opgave4RestService.Managers;

namespace Opgave4RestService.Controllers
{
    public class FootballPlayersController : Controller
    {
        private readonly FootballPlayerManager _footballPlayerManager = new FootballPlayerManager();
        // GET: FootballPlayersController
        public IEnumerable<FootballPlayer> Get()
        {
            return _footballPlayerManager.GetAll();
        }

        // GET: FootballPlayersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FootballPlayersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FootballPlayersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FootballPlayersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FootballPlayersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FootballPlayersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FootballPlayersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
