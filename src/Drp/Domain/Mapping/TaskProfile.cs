using System;
using AutoMapper;
using Drp.Data.Entities;
using Drp.Domain.Models;

namespace Drp.Domain.Mapping
{
    public partial class TaskProfile
        : AutoMapper.Profile
    {
        public TaskProfile()
        {
            CreateMap<Drp.Data.Entities.Task, Drp.Domain.Models.TaskReadModel>();

            CreateMap<Drp.Domain.Models.TaskCreateModel, Drp.Data.Entities.Task>();

            CreateMap<Drp.Data.Entities.Task, Drp.Domain.Models.TaskUpdateModel>();

            CreateMap<Drp.Domain.Models.TaskUpdateModel, Drp.Data.Entities.Task>();

            CreateMap<Drp.Domain.Models.TaskReadModel, Drp.Domain.Models.TaskUpdateModel>();

        }

    }
}
