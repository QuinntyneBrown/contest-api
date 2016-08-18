using System;
using System.Collections.Generic;
using ContestsApi.Data;
using ContestsApi.Dtos;
using System.Data.Entity;
using System.Linq;
using ContestsApi.Models;

namespace ContestsApi.Services
{
    public class ContestEntryFormService : IContestEntryFormService
    {
        public ContestEntryFormService(IUow uow, ICacheProvider cacheProvider)
        {
            this.uow = uow;
            this.repository = uow.ContestEntryForms;
            this.cache = cacheProvider.GetCache();
        }

        public ContestEntryFormAddOrUpdateResponseDto AddOrUpdate(ContestEntryFormAddOrUpdateRequestDto request)
        {
            var entity = repository.GetAll()
                .FirstOrDefault(x => x.Id == request.Id && x.IsDeleted == false);
            if (entity == null) repository.Add(entity = new ContestEntryForm());
            entity.Name = request.Name;
            uow.SaveChanges();
            return new ContestEntryFormAddOrUpdateResponseDto(entity);
        }

        public dynamic Remove(int id)
        {
            var entity = repository.GetById(id);
            entity.IsDeleted = true;
            uow.SaveChanges();
            return id;
        }

        public ICollection<ContestEntryFormDto> Get()
        {
            ICollection<ContestEntryFormDto> response = new HashSet<ContestEntryFormDto>();
            var entities = repository.GetAll().Where(x => x.IsDeleted == false).ToList();
            foreach(var entity in entities) { response.Add(new ContestEntryFormDto(entity)); }    
            return response;
        }


        public ContestEntryFormDto GetById(int id)
        {
            return new ContestEntryFormDto(repository.GetAll().Where(x => x.Id == id && x.IsDeleted == false).FirstOrDefault());
        }

        protected readonly IUow uow;
        protected readonly IRepository<ContestEntryForm> repository;
        protected readonly ICache cache;
    }
}
