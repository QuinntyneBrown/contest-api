using System.Collections.Generic;
using ContestsApi.Data;
using ContestsApi.Dtos;
using System.Linq;
using ContestsApi.Models;

namespace ContestsApi.Services
{
    public class ContestEntryService : IContestEntryService
    {
        public ContestEntryService(IUow uow, ICacheProvider cacheProvider)
        {
            _uow = uow;
            _repository = uow.ContestEntries;
            _cache = cacheProvider.GetCache();
        }

        public ContestEntryAddOrUpdateResponseDto AddOrUpdate(ContestEntryAddOrUpdateRequestDto request)
        {
            var entity = _repository.GetAll()
                .FirstOrDefault(x => x.Id == request.Id && x.IsDeleted == false);
            if (entity == null) _repository.Add(entity = new ContestEntry());
            entity.Name = request.Name;
            _uow.SaveChanges();
            return new ContestEntryAddOrUpdateResponseDto(entity);
        }

        public dynamic Remove(int id)
        {
            var entity = _repository.GetById(id);
            entity.IsDeleted = true;
            _uow.SaveChanges();
            return id;
        }

        public ICollection<ContestEntryDto> Get()
        {
            ICollection<ContestEntryDto> response = new HashSet<ContestEntryDto>();
            var entities = _repository.GetAll().Where(x => x.IsDeleted == false).ToList();
            foreach(var entity in entities) { response.Add(new ContestEntryDto(entity)); }    
            return response;
        }
        
        public ContestEntryDto GetById(int id)
        {
            return new ContestEntryDto(_repository.GetAll().Where(x => x.Id == id && x.IsDeleted == false).FirstOrDefault());
        }

        protected readonly IUow _uow;
        protected readonly IRepository<ContestEntry> _repository;
        protected readonly ICache _cache;
    }
}
