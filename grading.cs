using System;

namespace grading_system
{
    internal class Grades
    {
        string name;
        int admno;
        int be, entr, comm, os;
        double average;
        void Enters()
        {
            Console.WriteLine("Enter Student Name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter Admission Number:");
            admno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks for Basic Electronics:");
            be = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks for Entrepreneur:");
            entr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks for Communication Skills:");
            comm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks for Understand OS:");
            os = Convert.ToInt32(Console.ReadLine());
        }

        void grading()
        {
            if (be != 0 && comm != 0 && entr != 0 && os != 0)
            {
                average = (be + entr + comm + os) / 4;
            }
            else
            {
                Console.WriteLine("Exam requirements not met");
            }

            if (average >= 80 && average <= 100)
            {
                Console.WriteLine("Student Report \n");
                Console.WriteLine("..................");
                Console.WriteLine(" Mastery");
                Console.WriteLine(" Average : " + average);
            }
            if (average >= 60 && average < 80)
            {
                Console.WriteLine("Student Report \n");
                Console.WriteLine("..................");
                Console.WriteLine(" Proficient");
                Console.WriteLine(" Average : " + average);
            }
            if (average >= 40 && average < 60)
            {
                Console.WriteLine("Student Report \n");
                Console.WriteLine("..................");
                Console.WriteLine(" Pass");
                Console.WriteLine(" Average : " + average);
            }
            if (average < 40)
            {
                Console.WriteLine("Student Report \n");
                Console.WriteLine("..................");
                Console.WriteLine(" Fail");
                Console.WriteLine(" Average : " + average);
            }
            else if (average == 0)
            {
                Console.WriteLine("Student Report \n");
                Console.WriteLine("..................");
                Console.WriteLine(" Missing Marks");
                Console.WriteLine(" Kindly Visit the Exams Office " );
            }
        }

        static void Main(string[] args)
        {
            Grades tree = new Grades();
            tree.Enters();
            tree.grading();
            Console.ReadLine();
        }
    }
}
