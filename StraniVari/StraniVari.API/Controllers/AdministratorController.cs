using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class AdministratorController : BaseCRUDController<Administrator, AdministratorUpSertRequest, AdministratorUpSertRequest, GetAdministratorDetailsResponse>
    {
        public AdministratorController(IAdministratorService administratorService) : base(administratorService)
        {
        }
    }
}
