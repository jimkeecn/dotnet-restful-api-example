using Microsoft.EntityFrameworkCore;

namespace dotnetRestfulAPI.Models
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }

        public DbSet<simpleModel> simpleModel { get; set; }
    }
}