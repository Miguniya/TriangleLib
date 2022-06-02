using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testForDll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TriangleLibrary.TriangleLib.getTriangleType(5, 5, 4).ToString());
            Console.ReadKey();
        }
    }
}
