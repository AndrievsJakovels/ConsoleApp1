namespace Internetabanka.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Payment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Payment()
        {
            Payments1 = new HashSet<Payment>();
            Payments11 = new HashSet<Payment>();
        }

        public int Id { get; set; }

        public int? Konta1Id { get; set; }

        public int? Konta2Id { get; set; }

        public int Money { get; set; }

        [StringLength(200)]
        public string Resaon { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments1 { get; set; }

        public virtual Payment Payment1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments11 { get; set; }

        public virtual Payment Payment2 { get; set; }
    }
}
