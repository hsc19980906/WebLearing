using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCBook.Models;

namespace MVCBook.Data
{
    public class MVCBookContext : DbContext
    {
        public MVCBookContext (DbContextOptions<MVCBookContext> options)
            : base(options)
        {
        }

        public DbSet<MVCBook.Models.Book> Book { get; set; }
    }
}
