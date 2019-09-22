using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ITSolution.Framework.Core.CustomUserAPI.Data;
using ITSolution.Framework.Servers.Core.CustomerApi.Model;
using ITSolution.Framework.Server.Core.BaseClasses.Repository;

namespace ITE.WebClient.Pages.Clientes
{
    public class DeleteModel : PageModel
    {
        private readonly CustomerContext _context;

        public DeleteModel()
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.EntitySet.FindAsync(id);

            if (Customer != null)
            {
                _context.EntitySet.Remove(Customer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
