namespace MoviesApp4Logic.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Column("E-mail")]
        [StringLength(50)]
        public string E_mail { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }
    }
}
