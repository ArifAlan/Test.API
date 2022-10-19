using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Data.Models.Base
{
    public interface IAudit
    {
        long Id { get; set; }

        DateTime? CreateDate { get; set; }

        string CreatorUserId { get; set; }

        DateTime? UpdateDate { get; set; }

        string UpdaterUserId { get; set; }

        int? RowVersion { get; set; }
    }
}
