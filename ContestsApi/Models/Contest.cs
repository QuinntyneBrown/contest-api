using System.Collections.Generic;

namespace ContestsApi.Models
{
    public class Contest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ContestEntry> ContestEntryies { get; set; } = new HashSet<ContestEntry>();
        public bool IsDeleted { get; set; }
    }
}
