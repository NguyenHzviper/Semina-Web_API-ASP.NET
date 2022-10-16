using Semina.model;
using System.Linq;

namespace Semina.data
{
    public class DBInitializer
    {
        public void Initialize(EmployeeContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
