using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ITSolution.Framework.Core.CustomUserAPI.Data;
using ITSolution.Framework.Servers.Core.CustomerApi.Model;
using ITSolution.Framework.Server.Core.BaseClasses.Repository;

namespace ITE.WebClient.Pages.Clientes
{
    public class EditModel : PageModel
    {
        private readonly ITSolution.Framework.Core.CustomUserAPI.Data.CustomerContext _context;

        public EditModel()
        {
            _context = new CustomerContext(new ITSDbContextOptions());
        }

        [BindProperty]
        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.EntitySet.FirstOrDefaultAsync(m => m.IdCliFor == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Customer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(Customer.IdCliFor))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CustomerExists(int id)
        {
            return _context.EntitySet.Any(e => e.IdCliFor == id);
        }
    }
}
