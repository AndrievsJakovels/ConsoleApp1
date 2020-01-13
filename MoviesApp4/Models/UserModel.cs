namespace MoviesApp4.Models
{
    using MoviesApp4Logic.Database;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserModel
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Column("Name")]
        [StringLength(50)]

        public string E_mail { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Password")]
        public string Password { get; set; }


        [NotMapped]
        [StringLength(50)]
        [Compare("Password", ErrorMessage = "Paroles nesakrit")]
        public string PasswordReapeat { get; set; }

        public static UserModel FromData(Users user)
        {
            return new UserModel()
            {
                Id = user.Id,
                E_mail = user.E_mail,
                Name = user.Name,
            };

        }


    }
}
