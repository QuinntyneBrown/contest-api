namespace ContestsApi.Dtos
{
    public class ContestDto
    {
        public ContestDto()
        {

        }

        public ContestDto(Models.Contest entity)
        {
            Id = entity.Id;
            Name = entity.Name;
        }

        public int? Id { get; set; }
        public string Name { get; set; }
    }
}
