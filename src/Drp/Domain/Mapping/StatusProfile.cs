using System;
using AutoMapper;
using Drp.Data.Entities;
using Drp.Domain.Models;

namespace Drp.Domain.Mapping
{
    public partial class StatusProfile
        : AutoMapper.Profile
    {
        public StatusProfile()
        {
            CreateMap<Drp.Data.Entities.Status, Drp.Domain.Models.StatusReadModel>();

            CreateMap<Drp.Domain.Models.StatusCreateModel, Drp.Data.Entities.Status>();

            CreateMap<Drp.Data.Entities.Status, Drp.Domain.Models.StatusUpdateModel>();

            CreateMap<Drp.Domain.Models.StatusUpdateModel, Drp.Data.Entities.Status>();

            CreateMap<Drp.Domain.Models.StatusReadModel, Drp.Domain.Models.StatusUpdateModel>();

        }

    }
}
