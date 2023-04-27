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

        }
    }
}