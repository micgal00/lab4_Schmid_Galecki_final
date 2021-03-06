#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lab4_Schmid_Galecki.Data;
using lab4_Schmid_Galecki.Models;

namespace lab4_Schmid_Galecki.Pages.Games
{
    public class DetailsModel : PageModel
    {
        private readonly lab4_Schmid_Galecki.Data.lab4_Schmid_GaleckiContext _context;

        public DetailsModel(lab4_Schmid_Galecki.Data.lab4_Schmid_GaleckiContext context)
        {
            _context = context;
        }

        public Game Game { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Game = await _context.Game.FirstOrDefaultAsync(m => m.ID == id);

            if (Game == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
