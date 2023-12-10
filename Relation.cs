using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    public class Relation
    {
        [Key]
        public int id { get; set; }
        public decimal Amount { get; set; }
        public int Donorid { get; set; }
        public Donor Donor { get; set; }
        public int Organizationid { get; set; }
        public Organization Organization { get; set; }
        public int Paymentid { get; set; }
        public Payment Payment { get; set; }

        // date & amount


    }
}
