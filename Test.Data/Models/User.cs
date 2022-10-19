using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Data.Models.Base;

namespace Test.Data.Models
{
    [Table("Users")]
    public class User : Audit
    {
        public string UserName { get; set; }

        public string Pass { get; set; }

        public string Phone { get; set; }
    }
}
