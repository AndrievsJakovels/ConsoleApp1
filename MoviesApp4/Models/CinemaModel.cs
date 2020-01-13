namespace MoviesApp4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CinemaModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CinemaModel()
        {
            Movies = new List<MovieModel>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [StringLength(50)]
        [Display(Name = "Adress")]
        public string Adress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public List<MovieModel> Movies { get; set; }

        public MoviesApp4Logic.Database.Cinema ToData()
        {
            return new MoviesApp4Logic.Database.Cinema()
            {
                Id = Id,
                Adress = Adress,
                Name = Name,
            };
        }
        public static CinemaModel FromData(MoviesApp4Logic.Database.Cinema data)
        {
            return new CinemaModel()
            {
                Id = data.Id,
                Adress = data.Adress,
                Name = data.Name,
            };





        }

        public int MovieCount { get; set; }
    }
}