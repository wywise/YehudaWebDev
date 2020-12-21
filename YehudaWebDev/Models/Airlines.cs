using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace YehudaWebDev.Models
{
    public class Airlines
    {
        [Display(Name = "ICAO")]
        [StringLength(4, MinimumLength = 3, ErrorMessage = "ICAO must be 3 to 4 characters")]
        [Required]
        public string Id { get; set; }

        [Display(Name = "Airline Name")]
        public string AirlineName { get; set; }

        [Display(Name = "Airline Base Country")]
        public string AirlineCountry { get; set; }

        [Display(Name = "Number of Airline Airplanes")]
        public int NumberOfPlanes { get; set; }

        [Display(Name = "Number of Airline Workers")]
        public int NumberOfWorkers { get; set; }

        [Display(Name = "Airline yearly travelers")]
        public double YearlyTravelerNumber { get; set; }

        [Display(Name = "Airline Year of establishment")]
        public int YearOfEstablishment { get; set; }

        [Display(Name = "Airline Airplanes list")]
        public ICollection<Airplanes> AirlineAirplanes { get; set; }

    }
}
