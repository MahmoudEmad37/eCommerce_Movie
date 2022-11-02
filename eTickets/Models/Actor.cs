using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int id { get; set; }
        public string profilePictureUrl { get; set; }
        public string name { get; set; }
        public string bio { get; set; }
        //Relationships
        public List<Actor_Movie> actors_movies { get; set; }
    }
}
