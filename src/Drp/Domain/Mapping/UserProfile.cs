using System;
using AutoMapper;
using Drp.Data.Entities;
using Drp.Domain.Models;

namespace Drp.Domain.Mapping
{
    public partial class UserProfile
        : AutoMapper.Profile
    {
        public UserProfile()
        {
            CreateMap<Drp.Data.Entities.User, Drp.Domain.Models.UserReadModel>();

            CreateMap<Drp.Domain.Models.UserCreateModel, Drp.Data.Entities.User>();

            CreateMap<Drp.Data.Entities.User, Drp.Domain.Models.UserUpdateModel>();

            CreateMap<Drp.Domain.Models.UserUpdateModel, Drp.Data.Entities.User>();

            CreateMap<Drp.Domain.Models.UserReadModel, Drp.Domain.Models.UserUpdateModel>();

        }

    }
}
