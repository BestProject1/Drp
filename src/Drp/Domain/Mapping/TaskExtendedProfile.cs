using System;
using AutoMapper;
using Drp.Data.Entities;
using Drp.Domain.Models;

namespace Drp.Domain.Mapping
{
    public partial class TaskExtendedProfile
        : AutoMapper.Profile
    {
        public TaskExtendedProfile()
        {
            CreateMap<Drp.Data.Entities.TaskExtended, Drp.Domain.Models.TaskExtendedReadModel>();

            CreateMap<Drp.Domain.Models.TaskExtendedCreateModel, Drp.Data.Entities.TaskExtended>();

            CreateMap<Drp.Data.Entities.TaskExtended, Drp.Domain.Models.TaskExtendedUpdateModel>();

            CreateMap<Drp.Domain.Models.TaskExtendedUpdateModel, Drp.Data.Entities.TaskExtended>();

            CreateMap<Drp.Domain.Models.TaskExtendedReadModel, Drp.Domain.Models.TaskExtendedUpdateModel>();

        }

    }
}
