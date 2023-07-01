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
    public class BaseCRUDController<T, TInsert, TUpdate, TGet> : BaseReadController<T,TGet> where TInsert : class where T :class where TGet:class
    {
        private readonly ICrudService<T, TInsert, TUpdate, TGet> _crudService;

        public BaseCRUDController(ICrudService<T, TInsert, TUpdate, TGet> crudService): base(crudService)
        {
            _crudService = crudService;
        }

        [HttpPost]
        [Authorize(Roles = Role.Administrator)]
        public virtual async Task<IActionResult> Insert([FromBody] TInsert request)
        {
            try
            {
                await _crudService.Insert(request);
                return Ok(new ResponseResult { Message = "You succeeded" });
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new ResponseResult { Message = "Insert failed: " + ex.Message });
            }
        }

        [HttpPut]
        [Authorize(Roles = Role.Administrator)]
        public virtual async Task<IActionResult> Update(int id, [FromBody] TUpdate request)
        {
            try
            {
                await _crudService.Update(id, request);
                return Ok(new ResponseResult { Message = "You succeeded" });
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new ResponseResult { Message = "Insert failed: " + ex.Message });
            }
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
