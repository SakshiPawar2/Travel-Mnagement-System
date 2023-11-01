using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Use_Utility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int addresult = AddClass.Add(10, 20);
            Console.WriteLine("Addresult: " + addresult);

            int addMulresult = MulClass.mul(10, 5);
            Console.WriteLine("addMulresult: " + addMulresult);

        }
    }
}
