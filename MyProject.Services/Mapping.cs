using AutoMapper;
using MyProject.Common.DTO;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services
{
    public class Mapping : Profile
    {
        public Mapping() {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Child, ChildDTO>().ReverseMap();
            //CreateMap<EGender, EGender>().ReverseMap();
            //CreateMap<EMedicalClinic, EMedicalClinic>().ReverseMap();

        }    
      
    }
}
