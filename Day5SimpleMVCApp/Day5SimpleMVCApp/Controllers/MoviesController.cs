﻿using Day5SimpleMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Day5SimpleMVCApp.Controllers
{
    public class MoviesController : Controller
    {
        private Repository _repo = new Repository();

        // GET: Movies
        public ActionResult Index(string path)
        {
            var movies = _repo.ListMovies();
            return View(movies);
        }
    }
}