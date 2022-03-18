using apidotnet5.Models;
using Microsoft.EntityFrameworkCore;

namespace apidotnet5.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {}

        public DbSet<Pessoa> pessoa { get; set;}
    }

}