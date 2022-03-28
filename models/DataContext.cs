using Microsoft.EntityFrameworkCore;

namespace TE19Dapi.models
{
    public class DataContext : DbContext
    {
        
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }

        public DbSet<Student> students {get; set;}
    }
}