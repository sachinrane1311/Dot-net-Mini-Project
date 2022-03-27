using Microsoft.EntityFrameworkCore;
using Mini_Project__.NET_Framework_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project__.NET_Framework_.Controller
{
    class AdminController
    {
       // StudentDbContext stuDb = new StudentDbContext();
        public static void AdminRole()
        {
           
           // Console.WriteLine("Welcome " + user.firstName);
            Console.WriteLine("1)Student Information\n2)Teacher Information\n3)Student MarksSheet\n4)Approve Student\n5)Approve Teacher ");
            int opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    Console.WriteLine("Student Information");
                    StudentController stuControl = new StudentController();
                    stuControl.studentRole();
                    break;

                case 2:
                    Console.WriteLine("Student Approval");
                    studentApproval();
                    break;

            }

        }

        public static void studentApproval()
        {
            StudentDbContext stuDb = new StudentDbContext();
            var students = stuDb.Students.FromSqlRaw("select * from Students where Admission_Approval = 0 ").ToList();
            foreach (Student student in students)
            {
                Console.WriteLine(student.standard);
            }
        }
    }
}
