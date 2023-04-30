using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Helper;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class BaseCRUDController<T, TUpsert, TGet> : BaseReadController<T,TGet> where TUpsert : class where T :class where TGet:class
    {
        private readonly ICrudService<T, TUpsert, TGet> _crudService;

        public BaseCRUDController(ICrudService<T, TUpsert, TGet> crudService): base(crudService)
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
    }
}
