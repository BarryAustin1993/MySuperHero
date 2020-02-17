using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHero.Data;
using SuperHero.Models;

namespace SuperHero.Controllers
{
    public class CSuperHeroController : Controller
    {
        private readonly ApplicationDbContext _context;

            public CSuperHeroController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CSuperHero
        public ActionResult Index()
        {
            return View(_context.SuperHeros.ToList());
        }

        // GET: CSuperHero/Details/5
        public ActionResult Details(int ID)
        {
            return View();
        }

        // GET: CSuperHero/Create
        public ActionResult Create()
        {
            CSuperHero superHero = new CSuperHero();
            return View(superHero);
        }

        // POST: CSuperHero/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CSuperHero superhero)
        {
            if (ModelState.IsValid)
            {
                _context.SuperHeros.Add(superhero);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        // GET: CSuperHero/Edit/5
        public ActionResult Edit(int ID)
        {
            return View(_context.SuperHeros.Find(ID));
        }

        // POST: CSuperHero/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CSuperHero superHero)
        {
            if (ModelState.IsValid)
            {
                _context.SuperHeros.Update(superHero);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return Edit(id, superHero);
            }
        }

        // GET: CSuperHero/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_context.SuperHeros.Find(id));
        }

        // POST: CSuperHero/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int ID, CSuperHero superHero)
        {
            if(ModelState.IsValid)
            {
                _context.SuperHeros.Remove(superHero);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return Delete(ID, superHero);
            }
        }
    }
}