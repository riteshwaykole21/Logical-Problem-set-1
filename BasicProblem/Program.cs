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
            Console.WriteLine("1 : Print Hello");
            Console.WriteLine("2 : Sum Of Two Number");
            Console.WriteLine("3 : Dividing Of Two Numbers");
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
                case 3:
                    DivindingNum divindingNum = new DivindingNum();
                    divindingNum.Number();
                    break;
            }
            Console.ReadLine();
        }
    }
}
