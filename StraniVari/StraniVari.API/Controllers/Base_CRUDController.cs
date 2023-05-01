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
    public class Base_CRUDController<T, TInsert, TUpdate, TGet> : BaseReadController<T, TGet> where TInsert : class where TUpdate : class where T : class where TGet : class
    {
        private readonly I_CrudService<T, TInsert, TUpdate, TGet> _crudService;

        public Base_CRUDController(I_CrudService<T, TInsert, TUpdate, TGet> crudService) : base(crudService)
        {
            _crudService = crudService;
        }

        [HttpPost]
        [Authorize(Roles = Role.Administrator)]
        public virtual async Task<IActionResult> Insert([FromBody] TInsert request)
        {
            await _crudService.Insert(request);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpPut]
        [Authorize(Roles = Role.Administrator)]
        public virtual async Task<IActionResult> Update(int id, [FromBody] TUpdate request)
        {
            await _crudService.Update(id, request);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpDelete]
        [Authorize(Roles = Role.Administrator)]
        public virtual async Task<IActionResult> Delete(int id)
        {
            await _crudService.Delete(id);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }
    }
}
