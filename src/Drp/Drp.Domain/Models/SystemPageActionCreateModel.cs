using System;
using System.Collections.Generic;

namespace Drp.Domain.Models
{
    public partial class SystemPageActionCreateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public DateTime DataChangeLastTime { get; set; }

        public long MenuId { get; set; }

        public string ActionId { get; set; }

        public string ActionName { get; set; }

        public string ControlName { get; set; }

        #endregion

    }
}
