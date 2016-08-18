namespace ContestsApi.Data
{
    public interface IUow
    {
        IRepository<Models.Contest> Contests { get; }
        IRepository<Models.ContestEntryForm> ContestEntryForms { get; }
        void SaveChanges();
    }
}
