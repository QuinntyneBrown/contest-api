using ContestsApi.Models;

namespace ContestsApi.Data
{
    public interface IUow
    {
        IRepository<Contest> Contests { get; }
        IRepository<ContestEntry> ContestEntries { get; }
        void SaveChanges();
    }
}
