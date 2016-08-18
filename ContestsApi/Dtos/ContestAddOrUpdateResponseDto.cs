namespace ContestsApi.Dtos
{
    public class ContestAddOrUpdateResponseDto: ContestDto
    {
        public ContestAddOrUpdateResponseDto(Models.Contest entity)
        :base(entity)
        {

        }
    }
}
