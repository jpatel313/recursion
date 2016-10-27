using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Fact(5));
        }



        static int Fact(int x)  //4!=4*3! // x!=x*(x-1)!
        { 
           
            if (x == 1)
                return 1;

            return x * Fact(x - 1);//Fact(x-1) allows returning the variable as input to run again


        }




    }
}
