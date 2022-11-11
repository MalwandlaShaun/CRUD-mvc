using Microsoft.EntityFrameworkCore;
using fullMVCProject.Models;
namespace fullMVCProject.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

    public DbSet<CategoryModel> Categories {get; set;}
    }
}