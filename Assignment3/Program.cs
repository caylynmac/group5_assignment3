using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Assignment3.ProblemDomain;
using Assignment3.Utility;

namespace Assignment3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //testing some methods before unit testing
            SLL list1 = new SLL();
            User user1 = new User(12, "m", "email", "something");
            list1.AddFirst(user1);
            list1.AddFirst(user1);
            list1.RemoveLast();
            list1.AddLast(user1);

            Console.WriteLine(list1.GetValue(0));

            Console.WriteLine(list1.GetValue(1));
            Console.WriteLine(list1.Count());
            //the normal debug run button doesn't work in this net version, use the rightmost run button
        }
    }
}
