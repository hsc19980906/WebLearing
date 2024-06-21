using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesBook.Data;
using RazorPagesBook.Models;

namespace RazorPagesBook.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesBook.Data.RazorPagesBookContext _context;

        public IndexModel(RazorPagesBook.Data.RazorPagesBookContext context)
        {
            _context = context;
        }
        [BindProperty(SupportsGet = true)]
        public string SearchKey { get; set; }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            var books=_context.Book.AsQueryable();//Linq查询from b in _context.Book select b
            if(!string.IsNullOrEmpty(SearchKey) )
            {
                books = books.Where(b => b.Title.Contains(SearchKey));
            }

            Book = await books.ToListAsync();
        }
    }
}
