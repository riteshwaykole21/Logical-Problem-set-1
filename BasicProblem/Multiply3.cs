using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class Multiply3
    {
        public void Number()
        {
            Console.WriteLine("Enter A First Number");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Second Number");
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Third Number");
            int Z = Convert.ToInt32(Console.ReadLine());
            int Mul = X * Y * Z;
            Console.WriteLine($"{Mul}");
        }
    }
}
