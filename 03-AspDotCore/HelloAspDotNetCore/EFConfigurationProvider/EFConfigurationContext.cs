using HelloAspDotNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloAspDotNetCore.EFConfigurationProvider
{
    public class EFConfigurationContext:DbContext
    {
        public EFConfigurationContext(DbContextOptions options):base(options) { }

        public DbSet<EFConfigurationValue> Values { get; set; }
    }
}
