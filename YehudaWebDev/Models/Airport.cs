using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace YehudaWebDev.Models
{
    public class Airport
    {

        [Display(Name = "Airport Code")]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "Airport Code must be 3 characters")]
        [Required]
        public string Id { get; set; }
        
        [Display(Name = "Airport Name")]
        [Required]
        public string AirportName { get; set; }

        [Display(Name = "Airport Country")]
        [Required]
        public string AirportCountry { get; set; }

        [Display(Name = "Airport City")]
        public string AirportCity { get; set; }

        [Display(Name = "Airport Address")]
        [Required]
        public string AirportAddress { get; set; }

        [Display(Name = "Airport Size")]
        [StringLength(4, MinimumLength = 3, ErrorMessage = "Airport Size must be 3 to 4 characters")]
        [Required]
        public string AirportSize { get; set; }
    }
}
