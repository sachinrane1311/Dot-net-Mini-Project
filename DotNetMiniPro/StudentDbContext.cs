using Microsoft.EntityFrameworkCore;
using Mini_Project__.NET_Framework_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project__.NET_Framework_

{
    class StudentDbContext : DbContext
    {
        protected override void OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=PRATIKSHI-VD\SQL2017;Initial Catalog=StudentDB(.NET FW);User ID=sa;Password=cybage@123456; ");
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }


    }
}
