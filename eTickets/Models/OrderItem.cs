using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class OrderItem
    {
        [Key]
        public int id { get; set; }
        public int amount { get; set; }
        public double price { get; set; }
        public int movieId { get; set; }
        [ForeignKey("movieId")]
        public Movie movie { get; set; }
        public int orderId { get; set; }
        [ForeignKey("orderId")]
        public Order order { get; set; }
    }
}