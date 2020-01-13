namespace Internetabanka.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Account
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Money { get; set; }

        public int UsersId { get; set; }

        public virtual User User { get; set; }
    }
}
