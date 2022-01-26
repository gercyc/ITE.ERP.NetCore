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
    public class IndexModel : PageModel
    {
        private readonly CustomerContext _context;

        public IndexModel()
        {
            _context = new CustomerContext();
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.EntitySet.ToListAsync();
        }
    }
}
