using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Actor_Movie
    {
        public int movieId { get; set; }
        public Movie movie { get; set; }
        public int actorId { get; set; }
        public Actor actor { get; set; }
    }
}
