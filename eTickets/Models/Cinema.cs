using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Cinema: IEntityBase
    {
        [Key]
        public int id { get; set; }
        
        [Display(Name ="Cinema Logo")]
        [Required(ErrorMessage = "Cinema logo is required")]
        public string logoUrl { get; set; }

        [Display(Name = "Cinema Name")]
        [Required(ErrorMessage = "Cinema name is required")]
        public string name { get; set; }
        
        [Display(Name = "Cinema Description")]
        [Required(ErrorMessage = "Cinema description is required")]
        public string description { get; set; }
        
        //Relationships
        public List<Movie> movies { get; set; }
    }
}
