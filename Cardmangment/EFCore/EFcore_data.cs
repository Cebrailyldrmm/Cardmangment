using Microsoft.EntityFrameworkCore;



namespace Cardmangment.EFCore
{
    public class EFcore_data:DbContext
    {
        public EFcore_data(DbContextOptions<EFcore_data> options) : base(options)
        {

        }
        public DbSet<Customer> customers  { get; set; }
        public DbSet<Card> cards { get; set; }

    }
}
