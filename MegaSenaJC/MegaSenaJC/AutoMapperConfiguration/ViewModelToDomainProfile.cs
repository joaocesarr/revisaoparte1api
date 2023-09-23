using AutoMapper;
using MegaSena.Entities;
using MegaSena.Models;

namespace MegaSena.AutoMapperConfiguration
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile() 
        {
            CreateMap<MegaSenaViewModel, Entities.MegaSena>();
        }
    }
}
