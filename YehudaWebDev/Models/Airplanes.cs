using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace YehudaWebDev.Models
{
    public class Airplanes
    {
        [Display(Name = "Airplane Model")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Airplane Model must be 6 characters")]
        [Required]
        public string Id { get; set; }

        [Display(Name = "Manufacturer")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Manufacturer name must be 3 to 15 characters")]
        [Required]
        public string Manufacturer { get; set; }

        [Display(Name = "Airplane Model")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Airplane Model must be 3 to 15 characters")]
        [Required]
        public string AirplaneModel { get; set; }

        [Display(Name = "Airplane Manufacture Year")]
        [Range(1950, 2020)]
        public int ManufactureYear { get; set; }

        [Display(Name = "Ecoeconomy Seats")]
        [Range(0, 300)]
        [Required]
        public int EcoeconomySeats  { get; set; }

        [Display(Name = "Business Seats")]
        [Range(0,35)]
        [Required]
        public int BusinessSeats { get; set; }


        [Display(Name = "Airplane Airline")]
        [Required]
        public Airlines AirplaneAirline { get; set; }
    }
}
