using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Data.Models.Base
{
    public class Audit : IAudit
    {
        public Audit()
        {
            IsActive = true;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatorUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdaterUserId { get; set; }
        public int? RowVersion { get; set; }
    }
}
