using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OnlineHoppingStore.Domain.Entities
{
   public class Product
    {
        [HiddenInput(DisplayValue = false)]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Please Enter Value")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Value")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please Enter Value")]
        public decimal Price { get; set; }

        [Required(ErrorMessage ="Please Enter Value")]
        public string  Category { get; set; }

    }
}
