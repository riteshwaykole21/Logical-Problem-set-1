using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class DivindingNum
    {
        public void Number()
        {
            Console.WriteLine("Enter A First Number");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Second Number");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            int Div = 0;
            Div = FirstNumber / SecondNumber;
            Console.WriteLine($"The Division Of Two Number is {Div}");
        }
    }
}