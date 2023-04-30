using AutoMapper;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Mapper
{
    public class Auto_Mapper:Profile
    {
        public Auto_Mapper()
        { 
            CreateMap<School, SchoolUpsertRequest>().ReverseMap();
            CreateMap<School, GetSchoolDetailsResponse>().ReverseMap();

            CreateMap<Event, GetEventDetailsResponse>().ReverseMap();
            CreateMap<Event, EventUpsertRequest>().ReverseMap();
            CreateMap<Event, EventUpsertRequestMapp>().ReverseMap();

            CreateMap<Game, UpSertGameRequest>().ReverseMap();
            CreateMap<Game, GetGamesResponse>().ReverseMap();

            CreateMap<Material, MaterialUpsertRequest>().ReverseMap();
            CreateMap<Material, GetMaterialDetailsResponse>().ReverseMap();

            CreateMap<Notification, UpSertMeetingRequest>().ReverseMap();
            CreateMap<Notification, GetMeetingsResponse>().ReverseMap();

            CreateMap<PlanAndProgramme, UpSertPlanAndProgrammeRequest>().ReverseMap();
            CreateMap<PlanAndProgramme, GetPlanAndProgrameResposnse>().ReverseMap();

            CreateMap<Volunteer, VolunteerUpSertRequest>().ReverseMap();
            CreateMap<Volunteer, GetVolunteerDetailsResposne>().ReverseMap();
        }
    }
}