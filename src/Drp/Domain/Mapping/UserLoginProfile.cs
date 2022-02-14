using System;
using AutoMapper;
using Drp.Data.Entities;
using Drp.Domain.Models;

namespace Drp.Domain.Mapping
{
    public partial class UserLoginProfile
        : AutoMapper.Profile
    {
        public UserLoginProfile()
        {
            CreateMap<Drp.Data.Entities.UserLogin, Drp.Domain.Models.UserLoginReadModel>();

            CreateMap<Drp.Domain.Models.UserLoginCreateModel, Drp.Data.Entities.UserLogin>();

            CreateMap<Drp.Data.Entities.UserLogin, Drp.Domain.Models.UserLoginUpdateModel>();

            CreateMap<Drp.Domain.Models.UserLoginUpdateModel, Drp.Data.Entities.UserLogin>();

            CreateMap<Drp.Domain.Models.UserLoginReadModel, Drp.Domain.Models.UserLoginUpdateModel>();

        }

    }
}
