using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class Table
    {
        public void Numbers()
        {
            Console.WriteLine("Enter A Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Number * 1);
            Console.WriteLine(Number * 2);
            Console.WriteLine(Number * 3);
            Console.WriteLine(Number * 4);
            Console.WriteLine(Number * 5);
            Console.WriteLine(Number * 6);
            Console.WriteLine(Number * 7);
            Console.WriteLine(Number * 8);
            Console.WriteLine(Number * 9);
            Console.WriteLine(Number * 10);
        }
        public void ForLoop()
        {
            Console.WriteLine("Enter A Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * Number);
            }
        }
    }
}
