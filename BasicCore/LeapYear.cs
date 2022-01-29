using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    public class LeapYeer
    {
        public void Year(int Yeer)
        {
            if ((Yeer > 999) && (Yeer < 10000))
            {
                if ((Yeer % 4 == 0) && (Yeer % 100 != 0) || (Yeer % 400 == 0))
                    Console.WriteLine("{0} is a Leap year", +Yeer);
                else
                    Console.WriteLine("{0} is Not a Leap year", +Yeer);
            }
            else
                Console.WriteLine("Enter Four digit Valid Year :- ");
        }
    }
}
