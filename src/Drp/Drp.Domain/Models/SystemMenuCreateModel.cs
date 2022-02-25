using System;
using System.Collections.Generic;

namespace Drp.Domain.Models
{
    public partial class SystemMenuCreateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public DateTime DataChangeLastTime { get; set; }

        public bool IsActive { get; set; }

        public long ParentId { get; set; }

        public string Name { get; set; }

        public string Ico { get; set; }

        public string Url { get; set; }

        public int? OrderRule { get; set; }

        public int? Level { get; set; }

        public string Class { get; set; }

        #endregion

    }
}
