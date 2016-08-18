using System.ComponentModel.DataAnnotations.Schema;

namespace ContestsApi.Models
{
    public class ContestEntryForm
    {
        public int Id { get; set; }
        [ForeignKey("Contest")]
        public int? ContestId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
        public Contest Contest { get; set; }
    }
}
