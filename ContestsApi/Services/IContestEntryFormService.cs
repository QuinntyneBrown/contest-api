using ContestsApi.Dtos;
using System.Collections.Generic;

namespace ContestsApi.Services
{
    public interface IContestEntryFormService
    {
        ContestEntryFormAddOrUpdateResponseDto AddOrUpdate(ContestEntryFormAddOrUpdateRequestDto request);
        ICollection<ContestEntryFormDto> Get();
        ContestEntryFormDto GetById(int id);
        dynamic Remove(int id);
    }
}
