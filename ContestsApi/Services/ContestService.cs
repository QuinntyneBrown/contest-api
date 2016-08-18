using System;
using System.Collections.Generic;
using ContestsApi.Dtos;
using ContestsApi.Data;
using System.Linq;

namespace ContestsApi.Services
{
    public class ContestService : IContestService
    {
        public ContestService(IUow uow, ICacheProvider cacheProvider)
        {
            _uow = uow;
            _repository = uow.Contests;
            _cache = cacheProvider.GetCache();
        }

        public ContestAddOrUpdateResponseDto AddOrUpdate(ContestAddOrUpdateRequestDto request)
        {
            var entity = _repository.GetAll()
                .FirstOrDefault(x => x.Id == request.Id && x.IsDeleted == false);
            if (entity == null) _repository.Add(entity = new Models.Contest());
            entity.Name = request.Name;
            _uow.SaveChanges();
            return new ContestAddOrUpdateResponseDto(entity);
        }

        public ICollection<ContestDto> Get()
        {
            ICollection<ContestDto> response = new HashSet<ContestDto>();
            var entities = _repository.GetAll().Where(x => x.IsDeleted == false).ToList();
            foreach (var entity in entities) { response.Add(new ContestDto(entity)); }
            return response;
        }

        public ContestDto GetById(int id)
        {
            return new ContestDto(_repository.GetAll().Where(x => x.Id == id && x.IsDeleted == false).FirstOrDefault());
        }

        public dynamic Remove(int id)
        {
            var entity = _repository.GetById(id);
            entity.IsDeleted = true;
            _uow.SaveChanges();
            return id;
        }

        protected readonly IUow _uow;
        protected readonly IRepository<Models.Contest> _repository;
        protected readonly ICache _cache;
    }
}
