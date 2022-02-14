using System;
using AutoMapper;
using Drp.Data.Entities;
using Drp.Domain.Models;

namespace Drp.Domain.Mapping
{
    public partial class UserRoleProfile
        : AutoMapper.Profile
    {
        public UserRoleProfile()
        {
            CreateMap<Drp.Data.Entities.UserRole, Drp.Domain.Models.UserRoleReadModel>();

            CreateMap<Drp.Domain.Models.UserRoleCreateModel, Drp.Data.Entities.UserRole>();

            CreateMap<Drp.Data.Entities.UserRole, Drp.Domain.Models.UserRoleUpdateModel>();

            CreateMap<Drp.Domain.Models.UserRoleUpdateModel, Drp.Data.Entities.UserRole>();

            CreateMap<Drp.Domain.Models.UserRoleReadModel, Drp.Domain.Models.UserRoleUpdateModel>();

        }

    }
}
