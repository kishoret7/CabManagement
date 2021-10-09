using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CabManagement.Models
{
    public class Booking
    {
        [DisplayName("Booking ID")]
        [Required]
        
        public int BookingId { get; set; }
        [DisplayName("Pickup Location")]
        [Required]
        [StringLength(50)]
        public string PickUp { get; set; }
        [DisplayName("Drop Location")]
        [Required]
        [StringLength(50)]
        public string Drop { get; set; }
        [DisplayName("Booking Type")]
        [Required]
        [StringLength(50)]
        public string BookingType { get; set; }
        [DisplayName("Online Booking")]
        
        public bool BookingMethod { get; set; }

        [DisplayName("Cab ID")]
        public Cab Cab { get; set; }

        [DisplayName("Cab ID")]
        public int CabId { get; set; }

        [DisplayName("Estimated Price")]
        [Range(0.00, 1000.00)]
        public decimal? PriceEstimate { get; set; }
    }
}
