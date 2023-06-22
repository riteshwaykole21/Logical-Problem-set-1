using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class AllOpration
    {
        public void Numbers()
        {
            Console.WriteLine("Enter A First Numbers");
            int First = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Second Number");
            int Second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(First + Second);
            Console.WriteLine(First - Second);
            Console.WriteLine(First * Second);
            Console.WriteLine(First / Second);
        }
    }
}
