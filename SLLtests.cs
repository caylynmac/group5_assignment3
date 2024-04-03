using System.Reflection.Metadata;
using System.Xml.Linq;
using NUnit.Framework;
using Assignment3.ProblemDomain;
using Assignment3.Utility;
using System.Collections.Generic;
using System.Collections;
using System;
namespace Assignment3.SLLTests

{
    //[TestClass]
    public class UnitTest1
    {

        private SLL linkedList;

        [SetUp]
        public void Setup()
        {
            linkedList = new SLL();
            User user1 = new User(123, "bob", "123@abc.ca", "Password");
            User user2 = new User(123, "sally", "123@abc.ca", "Password");
            User user3 = new User(123, "sam", "123@abc.ca", "Password");
            linkedList.AddLast(user1);
            linkedList.AddLast(user2);
            linkedList.AddLast(user3);

        }

        [Test]
        //tests isempty and clear methods
        public void IsEmptyTest()
        {
            linkedList.Clear();

            //after using clear method, check that the list is empty
            Assert.IsTrue(linkedList.IsEmpty());
            Assert.AreEqual(0, linkedList.Count());
        }

        //Adding nodes to the beginning of the list
        [Test]
        public void AddFirstTest()
        {
            User user1 = new User(123, "aga", "123@abc.ca", "Password");
            linkedList.AddFirst(user1);
            Assert.IsFalse(linkedList.IsEmpty());
            Assert.AreEqual(user1, linkedList.GetValue(0));
        }
        [Test]
        public void AddLastTest()
        {
            User user1 = new User(123, "aga", "123@abc.ca", "Password");
            linkedList.AddLast(user1);
            Assert.IsFalse(linkedList.IsEmpty());
            Assert.AreEqual(user1, linkedList.GetValue(3));
        }

        [Test]
        //insert at an index
        public void AddMiddleTest()
        {
            //old index 2
            User user3 = new User(123, "sam", "123@abc.ca", "Password");

            //new user to add at index 2
            User user1 = new User(123, "aga", "123@abc.ca", "Password");
            linkedList.Add(user1, 2);

            //check index 2 is new additon
            Assert.AreEqual(user1, linkedList.GetValue(2));

            //check index 3 is now old index 2
            Assert.AreEqual(user3, linkedList.GetValue(3));
        }

        [Test]
        public void ReplaceTest()
        {
            User user1 = new User(123, "aga", "123@abc.ca", "Password");
            int index = 2;

            linkedList.Replace(user1, index);

            Assert.AreEqual(user1, linkedList.GetValue(index));
        }

        [Test]
        public void CountTest()
        {
            Assert.AreEqual(3, linkedList.Count());
        }
        [Test]
        public void RemoveFirstTest()
        {
            User user1 = new User(123, "bga", "123@abc.ca", "Password");
            User user2 = new User(123, "aga", "123@abc.ca", "Password");

            linkedList.AddFirst(user1);
            linkedList.AddFirst(user2);

            linkedList.RemoveFirst();

            Assert.AreEqual(4, linkedList.Count());
            Assert.AreEqual(user1, linkedList.GetValue(0));
        }

        [Test]
        public void RemoveLastTest()
        {
            User user1 = new User(123, "bga", "123@abc.ca", "Password");
            User user2 = new User(123, "aga", "123@abc.ca", "Password");

            linkedList.AddLast(user1);
            linkedList.AddLast(user2);

            linkedList.RemoveLast();

            Assert.AreEqual(4, linkedList.Count());
            Assert.AreEqual(user1, linkedList.GetValue(3));
        }

        [Test]
        //test remove method with item in middle
        public void RemoveMiddleTest()
        {
            //index 1 should become user sam
            User user3 = new User(123, "sam", "123@abc.ca", "Password");

            linkedList.Remove(1);

            Assert.AreEqual(2, linkedList.Count());
            Assert.AreEqual(user3, linkedList.GetValue(1));
        }

        [Test]
        //use indexof and getvalue methods to find and retrieve an item
        public void FindAndRetrieveTest()
        {
            User user3 = new User(123, "sam", "123@abc.ca", "Password");
            int index = linkedList.IndexOf(user3);
            linkedList.GetValue(index);

            Assert.AreEqual(user3, linkedList.GetValue(2));
        }


        [Test]
        public void ContainsTest()
        {
            User user1 = new User(123, "aga", "123@abc.ca", "Password");
            User user2 = new User(123, "aga", "123@abc.ca", "Password");
            User user3 = new User(123, "aga", "123@abc.ca", "Password");
            linkedList.AddLast(user1);
            linkedList.AddLast(user2);
            linkedList.AddLast(user3);

            Assert.IsTrue(linkedList.Contains(user1));
        }

        [Test]
        public void ReverseTest()
        {
            User user1 = new User(123, "bob", "123@abc.ca", "Password");
            User user2 = new User(123, "sally", "123@abc.ca", "Password");
            User user3 = new User(123, "sam", "123@abc.ca", "Password");
            linkedList.AddLast(user1);
            linkedList.AddLast(user2);
            linkedList.AddLast(user3);

            linkedList.Reverse();

            //check user3 now in position 1
            Assert.AreEqual(user3, linkedList.GetValue(0));
        }
    }
}