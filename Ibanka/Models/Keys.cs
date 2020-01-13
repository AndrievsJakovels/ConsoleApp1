namespace Ibanka.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Keys
    {
        public int Id { get; set; }

        public int? KeyName { get; set; }

        public int UsersId { get; set; }

        public virtual Users Users { get; set; }
    }
}
