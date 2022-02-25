using System;
using AutoMapper;
using Drp.Data.Entities;
using Drp.Domain.Models;

namespace Drp.Domain.Mapping
{
    public partial class SystemMenuProfile
        : AutoMapper.Profile
    {
        public SystemMenuProfile()
        {
            CreateMap<Drp.Data.Entities.SystemMenu, Drp.Domain.Models.SystemMenuReadModel>();

            CreateMap<Drp.Domain.Models.SystemMenuCreateModel, Drp.Data.Entities.SystemMenu>();

            CreateMap<Drp.Data.Entities.SystemMenu, Drp.Domain.Models.SystemMenuUpdateModel>();

            CreateMap<Drp.Domain.Models.SystemMenuUpdateModel, Drp.Data.Entities.SystemMenu>();

            CreateMap<Drp.Domain.Models.SystemMenuReadModel, Drp.Domain.Models.SystemMenuUpdateModel>();

        }

    }
}
