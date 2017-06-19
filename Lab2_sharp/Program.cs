using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car b = new Car("asd", 12, 123, "2012/12/12" );
            b.WriteLine();
            b.AddRepairDate("01/02/2000");
            b.WriteLine();
            Truck C = new Truck("Truck", 40, 500, 321, "");
            C.WriteLine();

        }
    }
}
