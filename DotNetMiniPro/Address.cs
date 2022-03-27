using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project__.NET_Framework_.Models
{
    [Table("AddressTable")]
    public class Address
    {
        [Key]
        public int userId { get; set; }
        [MaxLength(50)]
        public string locality { get; set; }
        public string city { get; set; }
        public string pinCode { get; set; }
        public string state { get; set; }
        public string country { get; set; }

        public virtual User User { get; set; }
       
    }
}
