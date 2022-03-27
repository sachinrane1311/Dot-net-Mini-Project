using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project__.NET_Framework_.Models
{
    public class Student
    {
        [Key,ForeignKey("users")]
        public int studentID { get; set;  }
        [Column("Standard")]
        public int standard{ get; set;}
        public string div { get; set; }
        [Column("Admission_Approval")]
        public bool approval { get; set; }

        public virtual User users { get; set; }

        public virtual ICollection<Subject> subjects { get; set; }





    }
}
