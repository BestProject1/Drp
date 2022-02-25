using System;
using AutoMapper;
using Drp.Data.Entities;
using Drp.Domain.Models;

namespace Drp.Domain.Mapping
{
    public partial class SystemUserProfile
        : AutoMapper.Profile
    {
        public SystemUserProfile()
        {
            CreateMap<Drp.Data.Entities.SystemUser, Drp.Domain.Models.SystemUserReadModel>();

            CreateMap<Drp.Domain.Models.SystemUserCreateModel, Drp.Data.Entities.SystemUser>();

            CreateMap<Drp.Data.Entities.SystemUser, Drp.Domain.Models.SystemUserUpdateModel>();

            CreateMap<Drp.Domain.Models.SystemUserUpdateModel, Drp.Data.Entities.SystemUser>();

            CreateMap<Drp.Domain.Models.SystemUserReadModel, Drp.Domain.Models.SystemUserUpdateModel>();

        }

    }
}
