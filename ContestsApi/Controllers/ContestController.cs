using ContestsApi.Dtos;
using ContestsApi.Services;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace ContestsApi.Controllers
{
    [Authorize]
    [RoutePrefix("api/contest")]
    public class ContestController : ApiController
    {
        public ContestController(IContestService contestService)
        {
            _contestService = contestService;
        }

        [Route("add")]
        [HttpPost]
        [ResponseType(typeof(ContestAddOrUpdateResponseDto))]
        public IHttpActionResult Add(ContestAddOrUpdateRequestDto dto) { return Ok(_contestService.AddOrUpdate(dto)); }

        [Route("update")]
        [HttpPut]
        [ResponseType(typeof(ContestAddOrUpdateResponseDto))]
        public IHttpActionResult Update(ContestAddOrUpdateRequestDto dto) { return Ok(_contestService.AddOrUpdate(dto)); }

        [Route("get")]
        [AllowAnonymous]
        [HttpGet]
        [ResponseType(typeof(ICollection<ContestDto>))]
        public IHttpActionResult Get() { return Ok(_contestService.Get()); }

        [Route("getById")]
        [HttpGet]
        [ResponseType(typeof(ContestDto))]
        public IHttpActionResult GetById(int id) { return Ok(_contestService.GetById(id)); }

        [Route("remove")]
        [HttpDelete]
        [ResponseType(typeof(int))]
        public IHttpActionResult Remove(int id) { return Ok(_contestService.Remove(id)); }

        protected readonly IContestService _contestService;


    }
}
