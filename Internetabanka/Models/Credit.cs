namespace Internetabanka.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Credit")]
    public partial class Credit
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string CreditType { get; set; }

        public int Money { get; set; }

        public int Duration { get; set; }

        [StringLength(200)]
        public string Comment { get; set; }

        public int? UsersID { get; set; }

        public virtual User User { get; set; }
    }
}
