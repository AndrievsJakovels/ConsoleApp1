using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ibanka.Models
{
    public partial class PaymentModel
    {
        //  List<Keys> keys { get; set; }
    
        public int jaunsId { get; set; }
        public int KeyName { get; set; }
        public int Kartesnr { get; set; }
        public List<Payments> Payments { get; set; }

        public int Id { get; set; }

        public int? Konta1Id { get; set; }

        public int? Konta2Id { get; set; }

        public int AccountMoney { get; set; }
        [StringLength(50)]
        public string Name { get; set; }


        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        [StringLength(200)]
        public string Resaon { get; set; }


/*
        public Ibanka.Models.PaymentModel FromData()
        {
            return new PaymentModel()
            {
                Id = Id,
                Konta1Id = Konta1Id,
                Konta2Id = Konta2Id,
                Resaon = Resaon,
            };
        }


    */


    }
}