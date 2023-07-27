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
        }
    }
}
