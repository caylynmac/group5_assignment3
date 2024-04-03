using System;
using System.Collections.Generic;
using Assignment3.ProblemDomain;
using Assignment3.Utility;
namespace Assignment3
{

    //ignore this, random preliminary tests
    public class Program
    {
        static void Main(string[] args)
        {
            //ignore this, random preliminary tests
            ////testing some methods before unit testing
            //SLL list1 = new SLL();
            //User user1 = new User(12, "m", "email", "something");
            //list1.AddFirst(user1);
            //list1.AddLast(user1);

            //Console.WriteLine(list1.GetValue(0));

            //Console.WriteLine(list1.GetValue(1));
            //Console.WriteLine(list1.Count());
            ////the normal debug run button doesn't work in this net version, use the rightmost run button

            //// Create a singly linked list
            SLL list = new SLL();

            //// Create a user object for testing
            //User user = new User(12, "John Doe", "johndoe@example.com", "password");




            //// Add users to the list
            //list.AddFirst(user);
            //list.AddFirst(user); // Adding the same user again for testing duplicate handling
            //list.RemoveLast(); // Removing the last added user
            //list.AddLast(user1); // Adding the user again to test AddLast method
            //list.Reverse();

            User user0 = new User(123, "bob", "123@abc.ca", "Password");
            User user2 = new User(123, "sally", "123@abc.ca", "Password");
            User user3 = new User(123, "sam", "123@abc.ca", "Password");
            list.AddLast(user0);
            list.AddLast(user2);
            list.AddLast(user3);
            list.Add(user0, 2);
            //list.Reverse();

            // Output the first user's details
            User firstUser = list.GetValue(0);
            Console.WriteLine($"First User: {firstUser.Id}, {firstUser.Name}, {firstUser.Email}");

            // Output the second user's details
            User secondUser = list.GetValue(3);
            Console.WriteLine($"Second User: {secondUser.Id}, {secondUser.Name}, {secondUser.Email}");

            // Output the number of users in the list
            int count = list.Count();
            Console.WriteLine($"Total Users: {count}");
        }
    }
}
