using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplicationEV4
{
    class Student
    {
        // Data Members
        public int RollNo;
        public string Name;
        public string Course;
        public int fees;

        // Method 1 - Accept Student Details
        public void GetStudentData()
        {
            Console.Write("Enter Roll Number : ");
            RollNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name : ");
            Name = Console.ReadLine();

            Console.Write("Enter Course : ");
            Course = Console.ReadLine();

            Console.Write("Enter Fees you paid : ");
            fees = Convert.ToInt32(Console.ReadLine());
        }

        // Method 2 - Display Student Details
        public void DisplayStudentData()
        {
            Console.WriteLine("\n===== Student Details =====");
            Console.WriteLine("Roll Number : " + RollNo);
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Course      : " + Course);
            Console.WriteLine("Your paid fees are      : " + fees);
        }

        // Main Method
        static void Main(string[] args)
        {
            Student s = new Student();

            s.GetStudentData();
            s.DisplayStudentData();

            Console.ReadKey();
        }
    }

}
