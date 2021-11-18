using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlämningsuppgift_backend_1.Controllers
{
    public class KundController : Controller
    {
        // GET: KundController
        public ActionResult Index()
        {
            return View();
        }

        // GET: KundController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: KundController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KundController/Create
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

        // GET: KundController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KundController/Edit/5
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

        // GET: KundController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KundController/Delete/5
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
