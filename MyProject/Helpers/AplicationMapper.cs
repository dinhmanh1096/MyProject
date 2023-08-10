using AutoMapper;
using MyProject.Data;
using MyProject.Models;

namespace MyProject.Helpers
{
    public class AplicationMapper : Profile
    {
        public AplicationMapper() 
        { 
            CreateMap<Sport,SportModel>().ReverseMap();
            CreateMap<Role,RoleModel>().ReverseMap();
            CreateMap<Workout,WorkoutModel>().ReverseMap();
            CreateMap<User,UserModel>().ReverseMap();
            CreateMap<Sport,RequestSportModel>().ReverseMap();
            CreateMap<Role,RequestUserModel>().ReverseMap();
            CreateMap<Workout,RequestWorkoutModel>().ReverseMap();
            CreateMap<User,RequestUserModel>().ReverseMap();
        }
    }
}
