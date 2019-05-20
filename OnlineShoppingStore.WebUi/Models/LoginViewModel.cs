using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingStore.WebUi.Models
{
    public class LoginViewModel
    {
        [Required (ErrorMessage ="User Name can not be blank")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Password is required")]
        [StringLength(50,MinimumLength =6)]
        public string Password { get; set; }
    }
}