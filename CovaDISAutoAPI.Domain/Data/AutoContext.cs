
using Microsoft.EntityFrameworkCore;

namespace CovaDISAutoAPI.Domain.Data
{
    internal class AutoContext : DbContext
    {
        public AutoContext(DbContextOptions<AutoContext> options) : base(options)
        {
        }

    }
}
