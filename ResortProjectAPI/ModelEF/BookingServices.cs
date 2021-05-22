using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ResortProjectAPI.ModelEF
{
    public class BookingServices
    {
        [Key, Column(Order = 1)]
        [MaxLength(10)]
        public string BookingID { get; set; }

        [Key, Column(Order = 2)]
        [MaxLength(10)]
        public string ServiceID { get; set; }

        [ForeignKey("BookingID")]
        public virtual Booking Booking { get; set; }

        [ForeignKey("ServiceID")]
        public virtual Service Service { get; set; }
    }
}
