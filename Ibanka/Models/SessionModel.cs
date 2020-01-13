using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ibanka.Models
{
    public class SessionModel 
    {


        public Users user { get; set; }

        public Payments payments { get; set; }
        public int jaunsId { get; set; }

        public int citsId { get; set; }

        public int kontaId { get; set; }

        public Accounts account { get; set; }

        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public string AccountName { get; set; }


        [StringLength(50)]
        public string Password { get; set; }

        public int Konta1Id { get; set; }

        public int Konta2Id { get; set; }

        public int Money { get; set; }

        public int Kartesnr { get; set; }


        public int KeyName { get; set; }

        public int UsersId { get; set; }

        public int AccountMoney { get; set; }


        [StringLength(200)]
        public string Resaon { get; set; }


 








    }
}