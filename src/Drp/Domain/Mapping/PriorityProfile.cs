using System;
using AutoMapper;
using Drp.Data.Entities;
using Drp.Domain.Models;

namespace Drp.Domain.Mapping
{
    public partial class PriorityProfile
        : AutoMapper.Profile
    {
        public PriorityProfile()
        {
            CreateMap<Drp.Data.Entities.Priority, Drp.Domain.Models.PriorityReadModel>();

            CreateMap<Drp.Domain.Models.PriorityCreateModel, Drp.Data.Entities.Priority>();

            CreateMap<Drp.Data.Entities.Priority, Drp.Domain.Models.PriorityUpdateModel>();

            CreateMap<Drp.Domain.Models.PriorityUpdateModel, Drp.Data.Entities.Priority>();

            CreateMap<Drp.Domain.Models.PriorityReadModel, Drp.Domain.Models.PriorityUpdateModel>();

        }

    }
}
