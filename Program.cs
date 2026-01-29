using System.ComponentModel.Design;

namespace COMP003A.LectureActivity3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SECTION A - Acadenic Term Identification");
            Console.WriteLine(Console.ReadLine());
          
            int currentmonth = DateTime.Now.Month;
           
            Console.WriteLine("Month :");
          
            if (currentmonth >= 1 & currentmonth <= 5)
            {
                Console.WriteLine(" Spring Term");
            }
            else if (currentmonth == 6 || currentmonth ==7)
            {
                Console.WriteLine("Summer term");
            }
            else
            {
                Console.WriteLine("Fall Term");
            }

                Console.WriteLine("SECTION B - Campus Access Check");
            Console.WriteLine(Console.ReadLine());
           
            Console.Write(" Enter your age :");
            int age = int.Parse(Console.ReadLine());
            Console.Write(" Are You Currently Enrolled? (yes/No) :");
          
            bool isEnrolled = Console.ReadLine().ToLower() == "yes";
           
            Console.Write(" Do you Have a valid student ID? (Yes/No) :");
           
            bool hasstudentid = Console.ReadLine().ToLower() == "yes";
            if (age >= 18)
            {
                Console.WriteLine("Campuse Access Granted");
            }
            else
            {
                Console.WriteLine("Campuse Access Denied");
            }
                Console.WriteLine("SECTION C - Semester Code Lookup");
            Console.Write("Enter a semester code (SP, SU, or FA) :");
            string semestercode = Console.ReadLine();

            switch (semestercode)
            {
                case "SP":
                    Console.WriteLine("spring");
                    break;

                case "SU":
                    Console.WriteLine("Summer");
                    break;

                case "FA":
                    Console.WriteLine("Fall");
                    break;

                
                    Console.WriteLine("Invalid semester code");
            }
        }
    }
}
