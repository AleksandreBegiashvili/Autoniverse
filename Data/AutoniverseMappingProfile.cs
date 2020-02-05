using AutoMapper;
using Data.DTO;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class AutoniverseMappingProfile : Profile
    {
        public AutoniverseMappingProfile()
        {
            CreateMap<CarCategory, CarCategoryDTO>()
                .ForMember(dest =>
                    dest.Id,
                    opt => opt.MapFrom(src => src.Id))
                .ForMember(dest =>
                    dest.CarCategoryName,
                    opt => opt.MapFrom(src => src.CarCategoryName))
                .ReverseMap();

            CreateMap<Car, CarDTO>()
                .ReverseMap();
        }
    }
}
