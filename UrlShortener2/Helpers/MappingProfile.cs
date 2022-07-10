using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlShortener2.Data.Entities;
using UrlShortener2.Models;

namespace UrlShortener2.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterViewModel, User>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(um => string.Join("", um.Firstname, um.Lastname)))
                .ForMember(dest => dest.EmailConfirmed, opt => opt.MapFrom(src => true));

            CreateMap<ShortUrlModel, ShorterUrl>()
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => DateTime.Now));
        }
    }
}
