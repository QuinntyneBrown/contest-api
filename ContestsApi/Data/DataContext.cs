using System.Data.Entity;

namespace ContestsApi.Data
{
    public class DataContext: DbContext, IDbContext
    {
        public DataContext()
            : base(nameOrConnectionString: "ContestsApiDataContext")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            Configuration.AutoDetectChangesEnabled = true;
        }

        public DbSet<Models.Contest> Contests { get; set; }
        public DbSet<Models.ContestEntryForm> ContestEntryForms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        } 
    }
}
