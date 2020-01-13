namespace MovieApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Movies
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Year { get; set; }

        public int CinemaId { get; set; }

        public virtual Cinemas Cinemas { get; set; }
    }
}
