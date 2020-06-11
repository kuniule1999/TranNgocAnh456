﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BigSchool.ViewModels;
using BigSchool.Models;
namespace BigSchool.Controllers
{
    public class CoursesController : Controller
    {
       
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        public ActionResult Create()
        {
            var viewModels = new CourseViewmModel
            {
                Categories = _dbContext.Categories.ToList()
            };

            return View(viewModels);
        }

      
    }
}