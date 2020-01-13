using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesApp4.Models
{
    public class MovieReservationModel
    {
        public MovieModel Movie { get; set; }

        public List<MoviesSessionModel> Sessions { get; set; }

        public MovieReservationModel()
        {
            Sessions = new List<MoviesSessionModel>();

        }

    }
}