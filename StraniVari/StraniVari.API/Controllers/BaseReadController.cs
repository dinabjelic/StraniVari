using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Helper;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseReadController<T, TGet> : ControllerBase where T : class where TGet: class
    {
        protected readonly IReadService<T, TGet> _service;
        public BaseReadController(IReadService<T, TGet> service)
        {
            _service = service;
        }

        [HttpGet]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public virtual async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        [HttpGet("details")]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public virtual async Task<IActionResult> GetById(int id)
        {
            return Ok(await _service.GetById(id));
        }

    }
}
