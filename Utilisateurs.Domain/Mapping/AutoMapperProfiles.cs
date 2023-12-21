using AutoMapper;
using Utilisateurs.Domain.DTOs.RoleDTOs;
using Utilisateurs.Domain.DTOs.UtilisateurDTOs;
using Utilisateurs.Domain.DTOs.UtilisateurRoleDTOs;
using Utilisateurs.Domain.Entities;

namespace Utilisateurs.Domain.Mapping
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles() 
        {
            CreateMap<Utilisateur, UtilisateurDTO>().ReverseMap();
            CreateMap<Utilisateur, AddUtilisateurDTO>().ReverseMap();
            CreateMap<Utilisateur, UpdateUtilisateurDTO>().ReverseMap();

            CreateMap<Role, RoleDTO>().ReverseMap();
            CreateMap<Role, AddRoleDTO>().ReverseMap();
            CreateMap<Role, UpdateRoleDTO>().ReverseMap();

            CreateMap<UtilisateurRole, UtilisateurRoleDTO>().ReverseMap();
            CreateMap<UtilisateurRole, AddUtilisateurRoleDTO>().ReverseMap();
            CreateMap<UtilisateurRole, UpdateUtilisateurRoleDTO>().ReverseMap();
        }
    }
}
