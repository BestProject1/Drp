using System;
using AutoMapper;
using Drp.Data.Entities;
using Drp.Domain.Models;

namespace Drp.Domain.Mapping
{
    public partial class AuditProfile
        : AutoMapper.Profile
    {
        public AuditProfile()
        {
            CreateMap<Drp.Data.Entities.Audit, Drp.Domain.Models.AuditReadModel>();

            CreateMap<Drp.Domain.Models.AuditCreateModel, Drp.Data.Entities.Audit>();

            CreateMap<Drp.Data.Entities.Audit, Drp.Domain.Models.AuditUpdateModel>();

            CreateMap<Drp.Domain.Models.AuditUpdateModel, Drp.Data.Entities.Audit>();

            CreateMap<Drp.Domain.Models.AuditReadModel, Drp.Domain.Models.AuditUpdateModel>();

        }

    }
}
