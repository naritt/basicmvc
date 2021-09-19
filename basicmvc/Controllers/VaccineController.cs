using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using basicmvc.Entity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace basicmvc.Controllers
{
    public class VaccineController : Controller
    {
        private readonly workshopContext _context;

        public VaccineController(workshopContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var vaccineList = _context.Vaccines.ToList();
            return View(vaccineList);
        }

        // GET: /Vaccine/Detail/{id}
        public IActionResult Detail(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var vaccine = _context.Vaccines.SingleOrDefault(v => v.Id == id);
            if (vaccine == null)
            {
                return NotFound();
            }

            return View(vaccine);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name,Stock,Price")] Vaccine vaccine)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vaccine);
                _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vaccine);
        }

        // GET: /Vaccine/Edit/{id}
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaccine = _context.Vaccines.SingleOrDefault(v => v.Id == id);
            if (vaccine == null)
            {
                return NotFound();
            }

            return View(vaccine);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,Stock,Price")] Vaccine vaccine)
        {
            if (id != vaccine.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(vaccine);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(vaccine);
        }


        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaccine = _context.Vaccines.SingleOrDefault(v => v.Id == id);
            if (vaccine == null)
            {
                return NotFound();
            }

            _context.Remove(vaccine);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
