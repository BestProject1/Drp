using System;
using AutoMapper;
using Drp.Data.Entities;
using Drp.Domain.Models;

namespace Drp.Domain.Mapping
{
    public partial class SystemRoleProfile
        : AutoMapper.Profile
    {
        public SystemRoleProfile()
        {
            CreateMap<Drp.Data.Entities.SystemRole, Drp.Domain.Models.SystemRoleReadModel>();

            CreateMap<Drp.Domain.Models.SystemRoleCreateModel, Drp.Data.Entities.SystemRole>();

            CreateMap<Drp.Data.Entities.SystemRole, Drp.Domain.Models.SystemRoleUpdateModel>();

            CreateMap<Drp.Domain.Models.SystemRoleUpdateModel, Drp.Data.Entities.SystemRole>();

            CreateMap<Drp.Domain.Models.SystemRoleReadModel, Drp.Domain.Models.SystemRoleUpdateModel>();

        }

    }
}
