using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionAssist
{
    public class Program
    {
        static void Main(string[] args)
        {
            runApp();

        }
        static void runApp()
        {

           
            {
                string[] students = { "Sai", "Guru", "Tharun", "Venkat", "Kumar" };

                Student studentPrinter = new Student();
                studentPrinter.PrintStudentsViaRecursion(students, 0);
                Console.ReadLine(); 
            }

        }
       
        
    }
}
