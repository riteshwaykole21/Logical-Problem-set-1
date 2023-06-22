using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class AverageNumber
    {
        public void Number()
        {
            Console.WriteLine("Enter A First Number");
            int First = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Second Number");
            int Second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Third Number");
            int Third = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Fourth Number");
            int Four = Convert.ToInt32(Console.ReadLine()); 
            int Sum = First + Second + Third + Four;
            int Average = Sum / 4;
            Console.WriteLine($"{Average}");
        }
    }
}
