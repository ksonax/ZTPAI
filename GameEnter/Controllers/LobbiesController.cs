﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameEnter.Controllers
{
    public class LobbiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
