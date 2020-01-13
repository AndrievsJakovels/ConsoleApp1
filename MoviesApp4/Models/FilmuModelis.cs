using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MoviesApp4.Models
{
    public class FilmuModelis
    {
        public List<MovieModel> Movies = new List<MovieModel>();
        public List<CinemaModel> Cinemas = new List<CinemaModel>();
    }
}