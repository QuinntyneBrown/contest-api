using ContestsApi.Dtos;
using ContestsApi.Services;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace ContestsApi.Controllers
{
    [Authorize]
    [RoutePrefix("api/contestEntry")]
    public class ContestEntryController : ApiController
    {
        public ContestEntryController(IContestEntryService contestEntryService)
        {
            _contestEntryService = contestEntryService;
        }

        [Route("add")]
        [HttpPost]
        [ResponseType(typeof(ContestEntryAddOrUpdateResponseDto))]
        public IHttpActionResult Add(ContestEntryAddOrUpdateRequestDto dto) { return Ok(_contestEntryService.AddOrUpdate(dto)); }

        [Route("update")]
        [HttpPut]
        [ResponseType(typeof(ContestEntryAddOrUpdateResponseDto))]
        public IHttpActionResult Update(ContestEntryAddOrUpdateRequestDto dto) { return Ok(_contestEntryService.AddOrUpdate(dto)); }

        [Route("get")]
        [AllowAnonymous]
        [HttpGet]
        [ResponseType(typeof(ICollection<ContestEntryDto>))]
        public IHttpActionResult Get() { return Ok(_contestEntryService.Get()); }

        [Route("getById")]
        [HttpGet]
        [ResponseType(typeof(ContestEntryDto))]
        public IHttpActionResult GetById(int id) { return Ok(_contestEntryService.GetById(id)); }

        [Route("remove")]
        [HttpDelete]
        [ResponseType(typeof(int))]
        public IHttpActionResult Remove(int id) { return Ok(_contestEntryService.Remove(id)); }

        protected readonly IContestEntryService _contestEntryService;


    }
}
