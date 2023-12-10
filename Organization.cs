using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    public class Organization
    {
        [Key]
        public int id { get; set; }// email --> key
        [Required, MaxLength(12)]
        public string name { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required]
        public string description { get; set; }//kkkkkkkkkkkkkkkkkk
        [Required]
        [EmailAddress]
        public string organizationEmail { get; set; }
        [Required, MaxLength(11)]
        public string organizationPhoneNumber { get; set; }// orgPhoneNumber
        public byte[] image { get; set; }
        public ICollection<Donor> Donors { get; set; }
        public List<Relation> Relations { get; set; }

    }//  property  --->  Description 
}
