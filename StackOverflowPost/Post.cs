using System;
using System.Diagnostics;

namespace StackOverFlowPost
{
    class Post
    {
        private DateTime _date;
        private int _count = 0;
       

        public string Title { get; set; }


        public void datetime()
        {
            _date = DateTime.Now;
            
        }

        public void voting()
        {
            while (true)
            {
                Console.Write("For Upvote press 1 and for downvote press 2(or press Enter to exit): ");
                var input = Console.ReadLine();
                if (input == "1")
                    _count++;
                if (input == "2")
                    _count--;
                if (input !="1" || input != "2" || !String.IsNullOrWhiteSpace(input))
                    Console.WriteLine("Invalid entry,retry");
                
                if (String.IsNullOrWhiteSpace(input))
                    break;
            }
            Console.WriteLine("The post with the name {2} was created on {0} and got a total of {1} vote value", _date, _count, Title);
            
        }
    }
}