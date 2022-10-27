using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Drob_Andreea_Lab2.Data;
using Drob_Andreea_Lab2.Models;

namespace Drob_Andreea_Lab2.Pages.Authors
{
    public class CreateModel : PageModel
    {
        private readonly Drob_Andreea_Lab2.Data.Drob_Andreea_Lab2Context _context;

        public CreateModel(Drob_Andreea_Lab2.Data.Drob_Andreea_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["AuthorID"] = new SelectList(_context.Set<Author>(), "FirstID", "FirstName");
            ViewData["AuthorID"] = new SelectList(_context.Set<Author>(), "LastID", "LastName");
            return Page();
        }

        [BindProperty]
        public Author Author { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Author.Add(Author);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
