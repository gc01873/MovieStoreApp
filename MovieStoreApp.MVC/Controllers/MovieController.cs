using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStoreApp.MVC.Repository;
using MovieStoreApp.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace MovieStoreApp.MVC.Controllers
{
    public class MovieController : Controller
    {
        MovieRepository movies;

        public MovieController()
        {
            movies = new MovieRepository();
        }
        public IActionResult Index()
        {
            IEnumerable<MovieModel> lstmovies = movies.movieList();
            return View(lstmovies);
        }


        public IActionResult Detail(int Id)
            
        {
            MovieModel movie = movies.find(Id);

            return View(movie);

        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MovieModel moviemodel)
        {

            if (moviemodel.Title != null)
            {
                
                return RedirectToAction("Index");
            }
            //call the repository insert method to save the movie in database
            return View(moviemodel);
        }
    }
}