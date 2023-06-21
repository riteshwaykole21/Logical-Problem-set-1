using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class Sum
    {
        public void Num()
        {
            Console.WriteLine("Enter A First Number");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Second Number");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            int Sum = 0;
            Sum = FirstNumber + SecondNumber;
            Console.WriteLine(Sum);
        }
    }
}
