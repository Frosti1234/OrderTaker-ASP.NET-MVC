using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }

        public int OrderMasterId { get; set; }

        public int FoodItemId { get; set; }

        [ForeignKey("FoodItemId")]
        public FoodItem FoodItem { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal FoodItemPrice { get; set; }

        public int Quantity { get; set; }
    }
}