using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    public enum _Gender { Male, Female }
    public class Donor
    {
        [Key]
        public int id { get; set;} // email --> key
        [Required, MaxLength(12)]
        public string firstName { get; set; }
        [Required, MaxLength(12)]
        public string fastName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required, MaxLength(11)]
        public string phoneNumber { get; set; }
        [Required]
        public string country { get; set; }
        public _Gender gender { get; set; }
        public ICollection<Organization> Organizations { get; set; }
        public List<Relation> Relations { get; set; }

    }
}
