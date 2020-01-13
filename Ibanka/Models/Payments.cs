namespace Ibanka.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Payments
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string NamePayment { get; set; }

        public int Konta1Id { get; set; }

        public int Konta2Id { get; set; }

        public int AccountMoney { get; set; }

        [StringLength(200)]
        public string Resaon { get; set; }

        public virtual Accounts Accounts { get; set; }


    }
}
