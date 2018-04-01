using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace StackWithFor
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            var max = 5;
            var start = 0;

            for (var i =start; i<=max; i++)
                stack.Push(i);

            

            for (var i = start; i <= max; i++)
                Console.WriteLine(stack.Pop());

            
        }
    }
}
