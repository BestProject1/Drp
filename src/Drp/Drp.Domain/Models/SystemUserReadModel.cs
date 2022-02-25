using System;
using System.Collections.Generic;

namespace Drp.Domain.Models
{
    public partial class SystemUserReadModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public DateTime DataChangeLastTime { get; set; }

        public bool IsActive { get; set; }

        public string Eid { get; set; }

        public string UserName { get; set; }

        public string Pwd { get; set; }

        public string Phone { get; set; }

        public string LoginIp { get; set; }

        public string MenuRights { get; set; }

        public long RoleId { get; set; }

        public DateTime? LastLoginTime { get; set; }

        public string UserAgent { get; set; }

        public string CreateRoleName { get; set; }

        public string CreateUser { get; set; }

        #endregion

    }
}
