using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GN89.GrASM.Base;

namespace ConClient
{
    class Program
    {
        static void Main(string[] args)
        {
            bool test = Numbers.IsDec("23d");
            Console.WriteLine(test);
            Console.ReadLine();
        }
    }
}
