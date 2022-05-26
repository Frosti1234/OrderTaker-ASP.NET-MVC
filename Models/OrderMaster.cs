using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OrderMaster
    {
        [Key]
        public int OrderMasterId { get; set; }

        [Column(TypeName = "nvarchar(75)")]
        public string OrderNumber { get; set; }

        public int CustomerId { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string PMethod { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal GTotal { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        [ForeignKey("OrderMasterId")]
        public List<OrderDetail> OrderDetails { get; set; }
    }
}