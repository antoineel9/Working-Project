using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication15.Data;

namespace WebApplication15.Pages.NewClients
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication15.Data.ApplicationDbContext _context;

        public IndexModel(WebApplication15.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Clients> Clients { get;set; }

        public async Task OnGetAsync()
        {
            Clients = await _context.Clients.ToListAsync();
        }
    }
}
