using ContestsApi.Dtos;
using System.Collections.Generic;

namespace ContestsApi.Services
{
    public interface IContestService
    {
        ContestAddOrUpdateResponseDto AddOrUpdate(ContestAddOrUpdateRequestDto request);
        ICollection<ContestDto> Get();
        ContestDto GetById(int id);
        dynamic Remove(int id);
    }
}
