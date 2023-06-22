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
            Console.WriteLine("4 : Perform Specific Opration");
            Console.WriteLine("5 : After Swapping The Numbers");
            Console.WriteLine("6 : Multiply 3 Numbers");
            Console.WriteLine("7 : All Opration Perform");
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
                case 4:
                    SpecificOpra specificOpra = new SpecificOpra();
                    specificOpra.Number();
                    break;
                case 5:
                    SwappNum swappNum = new SwappNum();
                    swappNum.Numbers();
                    break;
                case 6:
                    Multiply3 multiply3 = new Multiply3();
                    multiply3.Number(); 
                    break;
                case 7:
                    AllOpration allOpration = new AllOpration();
                    allOpration.Numbers();  
                    break;
            }
            Console.ReadLine();
        }
    }
}
