using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Internetabanka.Models
{
    public class Login
    {
        public int Id { get; set; }
        [DisplayName("Lietotājs")]
        [StringLength(50)]
        public string Name { get; set; }

        

         
    }
}