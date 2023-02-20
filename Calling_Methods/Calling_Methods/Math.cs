using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    public class Math
        {
            public int integer { get; set; } // Creating a integer property

            public static int addMethod(int integer) // Creating a method in which 5 is added to integer and returns the result
        {
                return integer + 5;
            }

            public static int multiplyMethod(int integer) // Creating a medthod in which integer is multiplied by 5 and returns the result
        {
                return integer * 5;
            }

            public static int DivideMethod(int integer) // Creating a method in which integer is divided by 2 and returns the result
            {
                return integer / 2;
            }
        }
}
