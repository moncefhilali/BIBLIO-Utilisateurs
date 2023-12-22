using AutoMapper;
using Utilisateurs.Application.ViewModels;
using Utilisateurs.Domain.Entities;

namespace Utilisateurs.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Utilisateur, UtilisateurViewModel>().ReverseMap();

            CreateMap<Role, RoleViewModel>().ReverseMap();

            CreateMap<UtilisateurRole, UtilisateurRoleViewModel>().ReverseMap();
        }
    }
}
