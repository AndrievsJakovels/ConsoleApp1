namespace MoviesApp4Logic.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Session
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string Time { get; set; }

        [StringLength(10)]
        public string Price { get; set; }

        public int MovieId { get; set; }

        public virtual Movies Movy { get; set; }
    }
}
