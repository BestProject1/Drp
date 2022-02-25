using System;
using System.Collections.Generic;

namespace Drp.Domain.Models
{
    public partial class SystemRoleCreateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public DateTime DataChangeLastTime { get; set; }

        public bool IsActive { get; set; }

        public string MenuRights { get; set; }

        public string ActionList { get; set; }

        public string CreateUser { get; set; }

        public long CreateRoleId { get; set; }

        public string RoleName { get; set; }

        public string Description { get; set; }

        #endregion

    }
}
