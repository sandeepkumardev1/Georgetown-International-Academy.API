using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Georgetown_International_Academy.API.Database
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
    }
}
