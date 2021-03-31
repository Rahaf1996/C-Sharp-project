using System;
namespace Project
{
    class program
    {
        static void Main(string[] args)
        {
            string StudentName;
            int StudentGread;
            string Status;
            string quit = "";

            while (quit != "No")
            {
                Console.WriteLine("Would  you like to add a new student Yes or NO");
                quit = Console.ReadLine();
                if (quit == "yes")
                {
                    Console.WriteLine("Enter Student Name");
                    StudentName = Console.ReadLine();
                    Console.WriteLine("Enter Student Gread");
                    StudentGread = int.Parse(Console.ReadLine());
                    if (StudentGread >= 60)
                    {
                        Status = "prassed";
                    }
                    else {
                        Status = "Filed";
                         }

                    Console.WriteLine("Student Name={0} \n Student Gread={1} \n status={2} \n ", StudentName, StudentGread, Status);


                }
                else
                {
                    Console.WriteLine("please Enter Yor N ");
                }


            }
        }
          
    }
}