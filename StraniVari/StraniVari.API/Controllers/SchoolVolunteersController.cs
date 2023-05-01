using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class SchoolVolunteersController : Base_CRUDController<SchoolVolunteer, InsertVolunteerToSchoolRequest, UpdateVolunteerAssignedToSchoolRequest, GetVolunteersForSchoolResponse>
    {
        private readonly ISchoolVolunteerService _schoolVolunteerService;
        public SchoolVolunteersController(ISchoolVolunteerService schoolVolunteerService):base(schoolVolunteerService)
        {
            _schoolVolunteerService = schoolVolunteerService;
        }

        [HttpPost]
        [Authorize(Roles = Role.Administrator)]
        public override async Task<IActionResult> Insert(InsertVolunteerToSchoolRequest insertVolunteerToSchoolRequest)
        {
            //await _schoolVolunteerService.AddVolunteerToSchoolAsync(insertVolunteerToSchoolRequest);
            await base.Insert(insertVolunteerToSchoolRequest);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpGet("details")]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public override async Task<IActionResult> GetById(int id)
        {
            return Ok(await _schoolVolunteerService.GetById(id));
        }

        //[HttpPut]
        //[Authorize(Roles = Role.Administrator)]
        //public async Task<IActionResult> UpdateVolunteerDetails(UpdateVolunteerAssignedToSchoolRequest updateVolunteerAssignedToSchoolRequest)
        //{
        //    await _schoolVolunteerService.UpdateVolunteerDetailsAsync(updateVolunteerAssignedToSchoolRequest);
        //    return Ok(new ResponseResult { Message = "You succeeded" });
        //}

        //[HttpDelete]
        //[Authorize(Roles = Role.Administrator)]
        //public async Task<IActionResult> DeleteVolunteerFromSchool(int id)
        //{
        //    await _schoolVolunteerService.DeleteVolunteerFromSchoolAsync(id);
        //    return Ok(new ResponseResult { Message = "You succeeded" });
        //}
    }
}
