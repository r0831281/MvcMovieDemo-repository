using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.DAL;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class RatingsController : Controller
    {
        private readonly IRepository<Rating> _ratingRepository;

        public RatingsController(IRepository<Rating> ratingRepo)
        {
            _ratingRepository = ratingRepo;
        }

        // GET: Ratings/List
        public IActionResult List()
        {
            var ratings = _ratingRepository.GetAll();

            return View(ratings);
        }

        // GET: Ratings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ratings/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("RatingID,Code,Name")] Rating rating)
        {
            _ratingRepository.insert(rating);
            return View(rating);
        }

        // GET: Ratings/Edit/5
        public IActionResult Edit(int id)
        {
            var rating = _ratingRepository.GetById(id);

            return View(rating);
        }

        // POST: Ratings/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("RatingID,Code,Name")] Rating rating)
        {
            _ratingRepository.update(rating);

            return View(rating);
        }

        // GET: Ratings/Delete/5
        public IActionResult Delete(int id)
        {
            _ratingRepository.delete(id);
            return RedirectToAction("List");
        }

    }
}
