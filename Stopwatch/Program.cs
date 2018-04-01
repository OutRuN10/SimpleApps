using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            var duration = new mystopwatch();



            try
            {
                while (true)
                {
                    Console.Write("Press start to start the stopwatch or enter to exit: ");
                    var input1 = Console.ReadLine();
                    if (input1.ToLower() == "start")
                    {
                        count++;
                        duration.Start();

                        if (count > 2)
                            duration.Continue();
                    }
                    if (String.IsNullOrWhiteSpace(input1) || input1.ToLower() != "start")
                        break;
                    Console.Write("Press stop to stop the stopwatch: ");
                    var input2 = Console.ReadLine();
                    if (input2.ToLower() == "start")
                        throw new InvalidOperationException();

                    if (input2.ToLower() == "stop")
                        duration.Stop();
                    else break;

                }
                Console.WriteLine("The duration is {0}", duration.Calculate());

            }
            catch (Exception)
            {
                Console.WriteLine("You cannot restart the stopwatch before stopping it");
            }
            


            
            


        }
    }
}
