using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CabManagement.Models
{
    public class Cab
    {
        [DisplayName("Cab ID")]
        [Required]
        
        public int CabId { get; set; }

        [DisplayName("Driver Name")]
        [Required]
        [StringLength(50)]
        public string CabDriverName { get; set; }

        [DisplayName("Driver Contact Number")]
        [Required]
        [StringLength(10)]
        public string CabDriverPhNumber { get; set; }
        [DisplayName("Bookings")]
        public List<Booking> Booking { get; set; }

        [DisplayName("Routes")]
        public List<Route> Routes { get; set; }
        [DisplayName("Bills")]
        public List<Bill> Bills { get; set; }

        [DisplayName("Model")]
        [Required]
        [StringLength(50)]
        public string MakeModel { get; set; }
        [DisplayName("Car Rating")]
        [Required]
        [Range(1,5)]        
        public int CabRatings { get; set; }

        [DisplayName("Cab Type")]
        [Required]
        [StringLength(10)]
        public string CabType { get; set; }


        [DisplayName("Registration Number")]
        [Required]
        [StringLength(10)]
        public string RegistrationNumber { get; set; }
    }
}
