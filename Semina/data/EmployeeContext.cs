using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Semina.model;

namespace Semina.data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<S_EMP> S_EMP { get; set; }

    }
}
