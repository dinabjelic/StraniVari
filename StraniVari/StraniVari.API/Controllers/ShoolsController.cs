using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Requests;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class ShoolsController : BaseApiController
    {
        private readonly ISchoolService _schoolService;

        public ShoolsController(ISchoolService schoolService)
        {
            _schoolService = schoolService;
        }

        [HttpGet]
        public async Task<IActionResult> GetSchoolList()
        {
            return Ok(await _schoolService.SchoolListAsync());
        }

       [HttpGet("school-details")]
       public async Task<IActionResult> GetSchoolDetailsAsync(int id)
       {
            return Ok(await _schoolService.GetSchoolDetailsAsync(id));
       }

       [HttpDelete]
       public async Task<IActionResult> DeleteSchoolAsync(int id)
       {
            await _schoolService.DeleteSchoolAsync(id);
            return Ok("You successed");
       }

       [HttpPost]
       public async Task<IActionResult> AddSchoolAsync(SchoolUpsertRequest addSchoolRequest)
       {
            await _schoolService.AddSchoolAsync(addSchoolRequest);
            return Ok("You successed");
       }

       [HttpPut("{id}")]
       public async Task<IActionResult> UpdateSchoolAsync(int id, [FromBody] SchoolUpsertRequest updateSchoolRequest)
       {
            await _schoolService.UpdateSchoolAsync(id,updateSchoolRequest);
            return Ok("You successed");
       }
    }
}
