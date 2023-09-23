using AutoMapper;
using MegaSena.Entities;
using MegaSena.Models;

namespace MegaSena.AutoMapperConfiguration
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile() 
        {
            CreateMap<Entities.MegaSena, MegaSenaViewModel>();
        }
    }
}
