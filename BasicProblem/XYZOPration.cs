using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class XYZOPration
    {
        public void Number()
        {
            Console.WriteLine("Enter A First Number");
            int First = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Second Number");
            int Second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Third Number");
            int Third = Convert.ToInt32(Console.ReadLine());
            int opr1 = (First + Second)*Third;
            int opr2 = (First * Second) + (Second * Third);
            Console.WriteLine($"{opr1}   &&   {opr2}");
        }
    }
}
