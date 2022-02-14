using System;
using AutoMapper;
using Drp.Data.Entities;
using Drp.Domain.Models;

namespace Drp.Domain.Mapping
{
    public partial class RoleProfile
        : AutoMapper.Profile
    {
        public RoleProfile()
        {
            CreateMap<Drp.Data.Entities.Role, Drp.Domain.Models.RoleReadModel>();

            CreateMap<Drp.Domain.Models.RoleCreateModel, Drp.Data.Entities.Role>();

            CreateMap<Drp.Data.Entities.Role, Drp.Domain.Models.RoleUpdateModel>();

            CreateMap<Drp.Domain.Models.RoleUpdateModel, Drp.Data.Entities.Role>();

            CreateMap<Drp.Domain.Models.RoleReadModel, Drp.Domain.Models.RoleUpdateModel>();

        }

    }
}
