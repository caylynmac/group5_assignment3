using System;
using Assignment3.ProblemDomain;
using Assignment3.Utility;
namespace Assignment3;

public class Program
{
    static void Main(string[] args)
    {
        // Create a singly linked list
        ILinkedListADT list = new SLL();

        // Create a user object for testing
        User user = new User(12, "John Doe", "johndoe@example.com", "password");

        // Add users to the list
        list.AddFirst(user);
        list.AddFirst(user); // Adding the same user again for testing duplicate handling
        list.RemoveLast(); // Removing the last added user
        list.AddLast(user); // Adding the user again to test AddLast method

        // Output the first user's details
        User firstUser = list.GetValue(0);
        Console.WriteLine($"First User: {firstUser.Id}, {firstUser.Name}, {firstUser.Email}");

        // Output the second user's details
        User secondUser = list.GetValue(1);
        Console.WriteLine($"Second User: {secondUser.Id}, {secondUser.Name}, {secondUser.Email}");

        // Output the number of users in the list
        int count = list.Count();
        Console.WriteLine($"Total Users: {count}");
    }
}
