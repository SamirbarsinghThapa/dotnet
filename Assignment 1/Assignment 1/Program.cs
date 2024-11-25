using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Firstnumber = 10, Secondnumber = 15;

            Console.WriteLine($"Before Swap: Firstnumber = {Firstnumber}, Secondnumber = {Secondnumber}");

            Firstnumber = Firstnumber + Secondnumber; 
            Secondnumber = Firstnumber - Secondnumber; 
            Firstnumber = Firstnumber - Secondnumber; 

            Console.WriteLine($"After Swap: Firstnumber = {Firstnumber}, Secondnumber = {Secondnumber}");
        }
    }
}
