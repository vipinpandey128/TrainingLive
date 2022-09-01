using AutoMapper;
using TrainingLive.Models;
using TrainingLive.ViewModels;

namespace TrainingLive.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<UserViewModel, User>()
            //    .ForMember(dest=>dest.Email, opt=> opt.MapFrom(src => src.Email))
            //    .ForMember(dest=>dest.UserId, opt=> opt.MapFrom(src => src.UserId));  //ReverseMap() is used to map with both object

            CreateMap<UserViewModel, User>();
        }
    }
}
