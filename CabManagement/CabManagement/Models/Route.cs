using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CabManagement.Models
{
    public class Route
    {
        [DisplayName("Route ID")]
        [Required]
       
        public int RouteId { get; set; }
        [DisplayName("Distance")]
        [Required]
        [Range(0, 1000)]
        public int Distance { get; set; }

        public Cab Cab { get; set; }
        [DisplayName("Cab ID")]
        public int CabId { get; set; }
        
        public List<Bill> Bills { get; set; }
        [DisplayName("Route Category")]
        [Required]
        [StringLength(20)]
        public string RouteCategory { get; set; }
        [DisplayName("Estimated Time")]
        [DataType(DataType.DateTime)]
        public DateTime EstimatedTime { get; set; }
        [DisplayName("Has Tolls")]
        public bool Tolls { get; set; }
    }
}
