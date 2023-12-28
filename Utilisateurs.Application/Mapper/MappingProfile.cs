using AutoMapper;
using Utilisateurs.Application.Roles.ViewModel;
using Utilisateurs.Application.UtilisateurRoles.ViewModel;
using Utilisateurs.Application.Utilisateurs.ViewModel;
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
