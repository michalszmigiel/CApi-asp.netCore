using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityInfo.Api.Profiles
{
    public class PointsOfInterestProfile : Profile
    {
        public PointsOfInterestProfile()
        {
            CreateMap<Entities.PointOfInterest, Models.PointOfInterestDto>();
            CreateMap<Models.PointOfInterestForCreationDto, Entities.PointOfInterest>();
            CreateMap<Models.PointOfInterestForUpdateDto, Entities.PointOfInterest>().ReverseMap();
            //CreateMap<Entities.PointOfInterest, Models.PointOfInterestForUpdateDto>();
        }
    }
}
