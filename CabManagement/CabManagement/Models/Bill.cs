using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CabManagement.Models
{
    public class Bill
    {
        [DisplayName("Bill ID")]
        [Required]
        
        public int BillId { get; set; }
        [DisplayName("Bill Amount")]
        [Required]
        [Range(0.00, 2000.00)]
        public decimal BillAmount { get; set; }
        public Cab Cab { get; set; }
        [DisplayName("Cab ID")]
        public int CabId { get; set; }
        public Route Route { get; set; }
        [DisplayName("Route ID")]
        public int RouteId { get; set; }
        [DisplayName("Generated Time")]
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime GeneratedTime { get; set; }

        [DisplayName("Payment Status")]
        public string PaymentStatus { get; set; }
    }
}
