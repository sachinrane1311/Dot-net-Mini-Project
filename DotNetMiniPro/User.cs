using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project__.NET_Framework_.Models
{
    [Table("UserTable")]
    public class User
    {
        //User table columns

        [Key]
        public int userID { get; set; }

        [Column("First_Name")]
        [MaxLength(15)]
        public string firstName { get; set; }

        [Column("Last_Name")]
        [MaxLength(15)]
        public string lastName { get; set; }

        [Column("Date_Of_Birth")]
        public DateTime dob { get; set; }

        [Column("Mobile_No")]
        [MaxLength(10)]
        public string mobNo { get; set; }

        [Column("Gender")]
        [Required(ErrorMessage ="Gender is Required")]
        public string gender { get; set; }

        [Column("Age")]
        [MaxLength(3)]
        public int age { get; set; }

        [Column("Email_ID")]
        [Required(ErrorMessage = "Please enter the Email ID")]
        [MaxLength(20)]
        public string email { get; set; }

        [Column("Password")]
        [Required(ErrorMessage = "Please Enter the Password")]
        [MaxLength(12)]
        public string password { get; set; }

        [Column("Roles")]
        [Required(ErrorMessage = "Please Enter your Role")]
        public string role { get; set; }

        public virtual Address Address { get; set; }
        public virtual Student student { get; set; }
        public virtual Teacher teacher { get; set; }





    }
}
