using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineHoppingStore.Domain.Entities
{
   public class ShippingDetails
    {
        [Required (ErrorMessage ="Please Enter Value Field can't left Blank ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Value Field can't left Blank ")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        [Required(ErrorMessage = "Please Enter Value Field can't left Blank ")]
        public string City  { get; set; }
        [Required(ErrorMessage = "Please Enter Value Field can't left Blank ")]
        public string State { get; set; }
        public string Zip { get; set; }
        [Required(ErrorMessage = "Please Enter Value Field can't left Blank ")]
        public string Country { get; set; }
        public bool GiftWrap { get; set; }
    }
}
