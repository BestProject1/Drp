using System;
using AutoMapper;
using Drp.Data.Entities;
using Drp.Domain.Models;

namespace Drp.Domain.Mapping
{
    public partial class SystemPageActionProfile
        : AutoMapper.Profile
    {
        public SystemPageActionProfile()
        {
            CreateMap<Drp.Data.Entities.SystemPageAction, Drp.Domain.Models.SystemPageActionReadModel>();

            CreateMap<Drp.Domain.Models.SystemPageActionCreateModel, Drp.Data.Entities.SystemPageAction>();

            CreateMap<Drp.Data.Entities.SystemPageAction, Drp.Domain.Models.SystemPageActionUpdateModel>();

            CreateMap<Drp.Domain.Models.SystemPageActionUpdateModel, Drp.Data.Entities.SystemPageAction>();

            CreateMap<Drp.Domain.Models.SystemPageActionReadModel, Drp.Domain.Models.SystemPageActionUpdateModel>();

        }

    }
}
