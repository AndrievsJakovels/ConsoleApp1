using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesApp4.Models
{
    public class UserSessionModel

    {
        public UserModel user { get; set; }

        public List<MoviesSessionModel> Basket { get; set; }
        
        public UserSessionModel()
        {
                Basket = new List<MoviesSessionModel>();
        }


    }
}