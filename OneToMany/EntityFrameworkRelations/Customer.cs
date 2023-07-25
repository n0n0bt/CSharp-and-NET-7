using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkRelations
{
    [Table("CustomerMaster", Schema = "Admin")]
    public class Customer
    {
        public int CustomerID { get; set; }
        [Key]
        public int CustomerNo { get; set; }
        public string CustomerName { get; set; }
    }
}
