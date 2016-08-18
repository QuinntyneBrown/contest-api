using ContestsApi.Dtos;
using ContestsApi.Services;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace ContestsApi.Controllers
{
    [Authorize]
    [RoutePrefix("api/contestEntryForm")]
    public class ContestEntryFormController : ApiController
    {
        public ContestEntryFormController(IContestEntryFormService contestEntryFormService)
        {
            _contestEntryFormService = contestEntryFormService;
        }

        [Route("add")]
        [HttpPost]
        [ResponseType(typeof(ContestEntryFormAddOrUpdateResponseDto))]
        public IHttpActionResult Add(ContestEntryFormAddOrUpdateRequestDto dto) { return Ok(_contestEntryFormService.AddOrUpdate(dto)); }

        [Route("update")]
        [HttpPut]
        [ResponseType(typeof(ContestEntryFormAddOrUpdateResponseDto))]
        public IHttpActionResult Update(ContestEntryFormAddOrUpdateRequestDto dto) { return Ok(_contestEntryFormService.AddOrUpdate(dto)); }

        [Route("get")]
        [AllowAnonymous]
        [HttpGet]
        [ResponseType(typeof(ICollection<ContestEntryFormDto>))]
        public IHttpActionResult Get() { return Ok(_contestEntryFormService.Get()); }

        [Route("getById")]
        [HttpGet]
        [ResponseType(typeof(ContestEntryFormDto))]
        public IHttpActionResult GetById(int id) { return Ok(_contestEntryFormService.GetById(id)); }

        [Route("remove")]
        [HttpDelete]
        [ResponseType(typeof(int))]
        public IHttpActionResult Remove(int id) { return Ok(_contestEntryFormService.Remove(id)); }

        protected readonly IContestEntryFormService _contestEntryFormService;


    }
}
