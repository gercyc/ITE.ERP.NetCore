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
    public class DetailsModel : PageModel
    {
        private readonly CustomerContext _context;

        public DetailsModel()
        {
            _context = new CustomerContext();
        }

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
    }
}
