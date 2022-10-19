using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Data.Models.Base;

namespace Test.Data.Models
{
    [Table("Companies")]
    public class Company : Audit
    {
       
       public string Name { get; set; }

       public string Code { get; set; }

       public string Title { get; set; }

       public string TaxNumber { get; set; }
    }
}
