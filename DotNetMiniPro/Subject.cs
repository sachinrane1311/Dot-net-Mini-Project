using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Mini_Project__.NET_Framework_.Models
{
    public class Subject
    {
        [Key]
        public int subjectId { get; set; }
        public string subName { get; set; }
        public int standard { get; set; }
        public int max_marks { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        [ForeignKey("teacherID")]
        public virtual Teacher teacher { get; set; }
    }
}
