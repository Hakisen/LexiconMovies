using LexiconMovies.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMovies.ViewComponents
{
    public class StarsViewComponent : ViewComponent
    {
        private LexiconMoviesContext db;

        public StarsViewComponent(LexiconMoviesContext context)
        {
            db = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int movieId)
        {
            var movie = await db.Movie.FindAsync(movieId);
            var rating = movie.Rating;

            var doubleRating = (int)Math.Round(rating * 2);
            var model = new StarsViewModel
            {
                Stars = doubleRating / 2,
                HalfStar = doubleRating % 2 == 1
            };


            return View(model); //implicit vyn Default.cshtml i Shared/Stars
        }

    }

    public class StarsViewModel
    {
        public int Stars { get; set; }
        public bool HalfStar { get; set; }
    }

}
