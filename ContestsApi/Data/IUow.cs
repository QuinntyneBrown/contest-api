namespace ContestsApi.Data
{
    public interface IUow
    {
        IRepository<Models.Contest> Contests { get; }
        void SaveChanges();
    }
}
