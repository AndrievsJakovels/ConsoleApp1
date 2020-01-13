namespace MoviesApp4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MovieModel
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
        [Display(Name = "Name")]

        public int? Year { get; set; }
        [Display(Name = "Year")]

        public int CinemaId { get; set; }
        [Display(Name = "CinemaID")]

        public virtual CinemaModel Cinema { get; set; }

        public MoviesApp4Logic.Database.Movies ToData()
        {
            return new MoviesApp4Logic.Database.Movies()
            {
                Id = Id,
                Name = Name,
                CinemaId = CinemaId,
                Year = Year,
            };
    }

        public static MovieModel FromData(MoviesApp4Logic.Database.Movies data)
        {
            return new MovieModel()
            {
                Id = data.Id,
                CinemaId = data.CinemaId,
                Name = data.Name,
                Year = data.Year,
            };

        }

        public List<MoviesSessionModel> MovieSessions { get; set; }
    }
}
