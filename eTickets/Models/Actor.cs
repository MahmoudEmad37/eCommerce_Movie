using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int id { get; set; }

        [Display(Name ="Profile Picture URL")]
        public string profilePictureUrl { get; set; }
        [Display(Name ="Full Name")]
        public string name { get; set; }
        [Display(Name ="Biography")]
        public string bio { get; set; }
        //Relationships
        public List<Actor_Movie> actors_movies { get; set; }
    }
}
