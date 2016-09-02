using ContestsApi.Dtos;
using System.Collections.Generic;

namespace ContestsApi.Services
{
    public interface IContestEntryService
    {
        ContestEntryAddOrUpdateResponseDto AddOrUpdate(ContestEntryAddOrUpdateRequestDto request);
        ICollection<ContestEntryDto> Get();
        ContestEntryDto GetById(int id);
        dynamic Remove(int id);
    }
}
