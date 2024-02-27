using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ES_VETTORI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v1=new Vector(5,6);
            Vector v2 = new Vector(4, 7);
            double n = 3;
            double modulo = Vector.Modulo(v1);


            Console.WriteLine("{0}; {1};{2};{3});",v1 + v2, v1 - v2, v1 * v2, v1 * n);
                Console.WriteLine("{0};{1};{2},{3}", n*v1,v1/n, +v1, -v1);
            Console.WriteLine("{0}", modulo);

           Console.ReadLine();

            

        }
    }
}
