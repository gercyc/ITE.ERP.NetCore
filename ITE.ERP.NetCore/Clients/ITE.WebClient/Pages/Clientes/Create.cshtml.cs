using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ITSolution.Framework.Core.CustomUserAPI.Data;
using ITSolution.Framework.Servers.Core.CustomerApi.Model;
using ITSolution.Framework.Server.Core.BaseClasses.Repository;

namespace ITE.WebClient.Pages.Clientes
{
    public class CreateModel : PageModel
    {
        private readonly CustomerContext _context;

        public CreateModel()
        {
            _context = new CustomerContext();
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Customer Customer { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.EntitySet.Add(Customer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}