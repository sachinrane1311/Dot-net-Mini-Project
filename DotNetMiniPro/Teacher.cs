using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mini_Project__.NET_Framework_.Models
{
   public class Teacher
    {
        [Key,ForeignKey("users")]
        public int teacherID { get; set; }
        public string designation { get; set; }

        [Column("Confirmation")]
        public bool approval { get; set; }

        public virtual User users { get; set; }

        [ForeignKey("subjectId")]
        public virtual Subject subject { get; set; }

    }
}
