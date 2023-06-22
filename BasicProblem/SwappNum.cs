using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class SwappNum
    {
        public void Numbers()
        {
            Console.WriteLine("Enter A First Number");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Second Number");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("After Swapping The Number");
            Console.WriteLine($"The First Number is {SecondNumber}");
            Console.WriteLine($"The Second Number is {FirstNumber}");
        }
    }
}
