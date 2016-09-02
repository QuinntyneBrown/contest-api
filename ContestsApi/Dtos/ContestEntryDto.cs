namespace ContestsApi.Dtos
{
    public class ContestEntryDto
    {
        public ContestEntryDto(ContestsApi.Models.ContestEntry entity)
        {
            this.Id = entity.Id;
            this.Name = entity.Name;
        }

        public ContestEntryDto()
        {
            
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
