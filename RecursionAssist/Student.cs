using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionAssist
{
    public class Student
    {
        public void PrintStudentsViaRecursion(string[] students, int index)
        {
            if (index < students.Length)
            {
                Console.WriteLine(students[index]);
                PrintStudentsViaRecursion(students, index + 1);
            }
        }
    }
}
