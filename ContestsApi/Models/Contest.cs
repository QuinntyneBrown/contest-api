using System.Collections.Generic;

namespace ContestsApi.Models
{
    public class Contest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ContestEntryForm> ContestEntryForms { get; set; } = new HashSet<ContestEntryForm>();
        public bool IsDeleted { get; set; }
    }
}
