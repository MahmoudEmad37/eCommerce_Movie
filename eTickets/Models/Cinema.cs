using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int id { get; set; }
        public string logoUrl { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        //Relationships
        public List<Movie> movies { get; set; }
    }
}
