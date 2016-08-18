namespace ContestsApi.Dtos
{
    public class ContestEntryFormDto
    {
        public ContestEntryFormDto(ContestsApi.Models.ContestEntryForm entity)
        {
            this.Id = entity.Id;
            this.Name = entity.Name;
        }

        public ContestEntryFormDto()
        {
            
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
