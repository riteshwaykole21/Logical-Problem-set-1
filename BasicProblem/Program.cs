using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    PrintHello printHello = new PrintHello();
                    printHello.Hello();
                    break;
                case 2:
                    Sum sum = new Sum();
                    sum.Num();
                    break;
            }
            Console.ReadLine();
        }
    }
}
