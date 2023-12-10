using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    public class Payment
    {
        [Key]
        public int id { get; set; }
        public DateTime paymentDate { get; set; }//default
        [Required]
        public decimal amount { get; set; }
        public List<Relation> Relations { get; set; }
    }
}
