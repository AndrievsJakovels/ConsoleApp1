using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MoviesApp4.Models
{
    public class LoginModel
    {
        [StringLength(50)]
        public string E_mail { get; set; }



        [StringLength(50)]
        public string Password { get; set; }


    }
}