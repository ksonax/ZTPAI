﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GameEnter.Data;
using GameEnter.Models;

namespace GameEnter
{
    public class DetailsModel : PageModel
    {
        private readonly GameEnter.Data.DataContext _context;

        public DetailsModel(GameEnter.Data.DataContext context)
        {
            _context = context;
        }

        public Game GameModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GameModel = await _context.GameModel.FirstOrDefaultAsync(m => m.Id == id);

            if (GameModel == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
