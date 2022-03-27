using Microsoft.EntityFrameworkCore;
using Mini_Project__.NET_Framework_.Controller;
using Mini_Project__.NET_Framework_.Models;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace Mini_Project__.NET_Framework_
{
    class Program
    {

        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
            StudentDbContext stuDb = new StudentDbContext();
             User user = new User();
             Address adds = new Address();
            Student stu = new Student();
            Teacher teacher = new Teacher();

            /* user.firstName = "Pratik";
             user.lastName = "Shinde";
             user.mobNo = "9130960272";
             user.email = "pratik@gmail.com";
             user.password = "pratik@123";
             user.role = "Student";
             user.gender = "Male";

             adds.city = "Nagar";
             adds.country = "India";
             adds.locality = "Kedgaon";
             adds.pinCode = "414005";
             adds.state = "MH";

            /* stu.approval = false;
             stu.div = "A";
             stu.standard = 7;*/

            //Teacher Details
            teacher.designation = "Asistant Teacher";

             user.Address = adds;
            user.teacher = teacher;
            // user.student = stu;

            /*  stuDb.Users.Add(user);
              stuDb.SaveChanges();*/
            /*teacher = stuDb.Teachers.Find(5);
            Console.Write(teacher.approval);*/


            /* User user = stuDb.Users.Find(4);
             stuDb.Users.Remove(user);
             stuDb.SaveChanges();*/

            //Subject

            /* Subject sub = new Subject();
             sub.standard = 8;
             sub.subName = "Science";
             sub.max_marks = 100;
             stuDb.Subjects.Add(sub);
             stuDb.SaveChanges();*/

            Console.WriteLine("Welcome To Student Management System");

            Console.WriteLine("1) Login \n 2) Registrations");
            int opt =Convert.ToInt32( Console.ReadLine());
            if (opt == 1)
            {

                Console.WriteLine("Enter the Email ID");
                string email = Console.ReadLine();
                Console.WriteLine("Enter the Pasword");
                string pass = Console.ReadLine();
                login(email, pass);


            }
            else if (opt == 2) registration();

            else Console.WriteLine("Please give right options");






           
            
        }
       public static void registration()
        {
            StudentDbContext stuDb = new StudentDbContext();
            User user = new User();
            Console.WriteLine("Please Enter the FirstName");
            user.firstName = Console.ReadLine();

            Console.WriteLine("Please Enter the LastName");
            user.lastName = Console.ReadLine();

            Console.WriteLine("Please Select Gender : 1) Male 2) Female 3)TransGender");
            int option = Convert.ToInt32(Console.ReadLine());
            string gender = "";
            if (option == 1) gender = "Male";
            else if (option == 2) gender = "Female";
            else gender = "Transgender";
            user.gender = gender;

            Console.WriteLine("Please Enter the Date of Birth in Format of MM/DD/YYYY ");
            user.dob = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Please Enter the Age");
            user.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter the Email Id");
            user.email = Console.ReadLine();

            Console.WriteLine("Please Enter the Password");
            Console.ForegroundColor = ConsoleColor.Black;
            user.password = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Please Enter the Mobile Number");
            user.mobNo = Console.ReadLine();

            Address adds = new Address();
            Console.WriteLine("Enter the Locality");
            adds.locality = Console.ReadLine();

            Console.WriteLine("Enter the City");
            adds.locality = Console.ReadLine();

            Console.WriteLine("Enter the State");
            adds.state = Console.ReadLine();

            Console.WriteLine("Enter the Country");
            adds.country = Console.ReadLine();

            Console.WriteLine("Enter the PinCode");
            adds.pinCode = Console.ReadLine();

            //Adding the address to the User
            user.Address = adds;

            Console.WriteLine("Please Select Role : 1) Student 2) Teacher 3)Admin");
            int opt = Convert.ToInt32(Console.ReadLine());
            string role = "";
            if (opt == 1)
            {
                user.role = "Student";
                Student stu = new Student();

                Console.WriteLine("Please Enter Standard till 10th");
                stu.standard = Convert.ToInt32(Console.ReadLine());

                stu.approval = false;

                user.student = stu;
                stuDb.Users.Add(user);
                stuDb.SaveChanges();


            }
            else if (opt == 2)
            {
                user.role = "Teacher";
                Teacher teacher = new Teacher();
                teacher.approval = false;
                user.teacher = teacher;
                stuDb.Users.Add(user);
                stuDb.SaveChanges();
            }
            else
            {
                user.role = "Teacher";
                stuDb.Users.Add(user);
                stuDb.SaveChanges();
            }

        }
        public static void login(string email, string password)
        {
            StudentDbContext stuDb1 = new StudentDbContext();
            
            SqlParameter p1 = new SqlParameter();
            SqlParameter p2 = new SqlParameter();

            p1.ParameterName = "@Email_Id";
            p1.Value =email ;
            p1.SqlDbType = System.Data.SqlDbType.VarChar;
            p2.ParameterName = "@password";
            p2.Value = password;
            p2.SqlDbType = System.Data.SqlDbType.VarChar;
           // var user = (User)stuDb1.Users.FromSqlRaw("select * from UserTable where Email_ID = @Email_Id ");
             var users = stuDb1.Users.ToList();
            User user = new User();
            foreach (User user1 in users)
            {
                if (user1.email == email && user1.password == password) user = user1;
                //else Console.WriteLine("User Not Found");
            }


            if (user != null)
            {
                if (user.role == "Student")
                {
                    Console.WriteLine("You are in Student Role");
                   
                    // StudentRole();
                }
                else if (user.role == "Teacher")
                {
                    Console.WriteLine("You are in Teacher Role");
                    // TeacherRole();

                }
                else
                {
                    Console.WriteLine("You are in Admin Role");
                    AdminController.AdminRole();
                }
            }
            else Console.WriteLine("User Not Found");
            
        }
        
    }
}
