using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Order
    {
        [Key]
        public int id { get; set; }
        public string email { get; set; }
        public string userId { get; set; }
        [ForeignKey(nameof(userId))]
        public ApplicationUser User { get; set; }

        public List<OrderItem> OrderItem { get; set; }
    }
}
