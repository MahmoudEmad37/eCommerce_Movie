using eTickets.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string name { get; set; }
        public string desciption { get; set; }
        public double price  { get; set; }
        public string imageUrl { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public MovieCategory movieCategory { get; set; }
        //Relationships
        public List<Actor_Movie> actors_movies { get; set; }
        //Cinema
        public int cinemaId { get; set; }
        [ForeignKey("cinemaId")]
        public Cinema cinema { get; set; }
        //Producer
        public int producerId { get; set; }
        [ForeignKey("cinemaId")]
        public Producer producer { get; set; }
    }
}
