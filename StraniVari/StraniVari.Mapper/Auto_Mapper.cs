using AutoMapper;
using Microsoft.AspNetCore.Identity;
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
            CreateMap<Material, GetMaterialResponse>().ReverseMap();

            CreateMap<Notification, UpSertMeetingRequest>().ReverseMap();
            CreateMap<Notification, GetMeetingsResponse>().ReverseMap();

            CreateMap<PlanAndProgramme, UpSertPlanAndProgrammeRequest>().ReverseMap();
            CreateMap<PlanAndProgramme, GetPlanAndProgrameResposnse>().ReverseMap();

            CreateMap<Volunteer, VolunteerUpSertRequest>().ReverseMap();
            CreateMap<Volunteer, GetVolunteerDetailsResposne>().ReverseMap();

            CreateMap<SchoolMaterial, UpdateMaterialToSchoolRequest>().ReverseMap();
            CreateMap<SchoolMaterial, GetMaterialsForSchoolRequest>().ReverseMap();
            CreateMap<SchoolMaterial, InsertMaterialToSchoolRequest>().ReverseMap();


            CreateMap<EventSchool, EventSchoolUpdateRequest>().ReverseMap();
            CreateMap<EventSchool, GetSchoolsForEventResponse>().ReverseMap();
            CreateMap<EventSchool, EventSchoolInsertRequest>().ReverseMap();
            CreateMap<EventSchool, EventSchoolUpdateRequestMapp>().ReverseMap();


            CreateMap<SchoolVolunteer, UpdateVolunteerAssignedToSchoolRequest>().ReverseMap();
            CreateMap<SchoolVolunteer, GetVolunteersForSchoolResponse>().ReverseMap();

            CreateMap<Trip, UpSertTripRequest>().ReverseMap();
            CreateMap<Trip, GetTripResponse>().ReverseMap();
            CreateMap<Trip, GetTripsDetailsForEventResponse>().ReverseMap();
            CreateMap<Trip, UpdateTripRequest>().ReverseMap();

            CreateMap<TripStatus, StatusUpSertRequest>().ReverseMap();
            CreateMap<TripStatus, GetStatusResponse>().ReverseMap();

            CreateMap<VolunteerTrip, VolunteerTripUpdateRequest>().ReverseMap();

            CreateMap<Administrator, AdministratorUpSertRequest>().ReverseMap();
            CreateMap<Administrator, GetAdministratorDetailsResponse>().ReverseMap();
        }
    }
}