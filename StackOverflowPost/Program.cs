using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Post title: ");
            var newpost = new Post();
            newpost.Title = Console.ReadLine();
            newpost.datetime();
            newpost.voting();
            


        }
    }
}
