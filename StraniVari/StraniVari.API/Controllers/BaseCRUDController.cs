using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Helper;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;
using StraniVari.Services.Services;

namespace StraniVari.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class BaseCRUDController<T, TUpsert> : ControllerBase where TUpsert : class where T :class
    {
        private readonly ICrudService<T, TUpsert> _crudService;

        public BaseCRUDController(ICrudService<T, TUpsert> crudService)
        {
            _crudService = crudService;
        }

        [HttpPost]
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> Insert([FromBody] TUpsert request)
        {
            await _crudService.Insert(request);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpPut]
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> Update(int id, [FromBody] TUpsert request)
        {
            await _crudService.Update(id, request);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpDelete]
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> Delete(int id)
        {
            await _crudService.Delete(id);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpGet("get-all")]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _crudService.GetAll());
        }

        [HttpGet("school-details")]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _crudService.GetById(id));
        }

    }
}
