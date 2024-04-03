using Assignment3;

namespace Assignment3.Tests
{
    public class SLLtests
    {
        private SLL<int> linkedList;

        [SetUp]
        public void Setup()
        {
            // Initialize a new linked list before each test
            linkedList = new SLL<int>();
        }

        //Test is list is empty
        [Test]
        public void TestEmptyList()
        {
            Assert.AreEqual(0, linkedList.Count(), "Count should be 0 for an empty list");
        }

        //Test if list can prepend
        [Test]
        public void TestPrepend()
        {
            linkedList.Prepend(10);
            Assert.AreEqual(1, linkedList.Count(), "Count should be 1 after prepending an item");
        }

        //test if item is appended
        [Test]
        public void TestAppend()
        {
            linkedList.Append(20);
            Assert.AreEqual(1, linkedList.Count(), "Count should be 1 after appending an item");
        }

        //test if item is inserted at index
        [Test]
        public void TestInsertAtIndex()
        {
            linkedList.Append(10);
            linkedList.Append(30);
            linkedList.InsertAt(1, 20);
            Assert.AreEqual(3, linkedList.Count(), "Count should be 3 after inserting at index");
        }

        //test if item is replaced
        [Test]
        public void TestReplace()
        {
            linkedList.Append(10);
            linkedList.ReplaceAt(0, 20);
            Assert.AreEqual(1, linkedList.Count(), "Count should be 1 after replacing an item");
            Assert.AreEqual(20, linkedList.GetAt(0), "Replaced item should be 20");
        }

        //test if item is removed from beginning
        [Test]
        public void TestRemoveFirst()
        {
            linkedList.Append(10);
            linkedList.Append(20);
            linkedList.RemoveFirst();
            Assert.AreEqual(1, linkedList.Count(), "Count should be 1 after removing first item");
            Assert.AreEqual(20, linkedList.GetAt(0), "First item should be 20 after removal");
        }

        //test if item is removed from end
        [Test]
        public void TestRemoveLast()
        {
            linkedList.Append(10);
            linkedList.Append(20);
            linkedList.RemoveLast();
            Assert.AreEqual(1, linkedList.Count(), "Count should be 1 after removing last item");
            Assert.AreEqual(10, linkedList.GetAt(0), "Last item should be 10 after removal");
        }

        //test if item is removed at middle
        [Test]
        public void TestRemoveAt()
        {
            linkedList.Append(10);
            linkedList.Append(20);
            linkedList.Append(30);
            linkedList.RemoveAt(1);
            Assert.AreEqual(2, linkedList.Count(), "Count should be 2 after removing item at index 1");
            Assert.AreEqual(10, linkedList.GetAt(0), "First item should be 10 after removal");
            Assert.AreEqual(30, linkedList.GetAt(1), "Second item should be 30 after removal");
        }

        //test if item is existing, and can be retrieved
        [Test]
        public void TestGetIndexOfItem()
        {
            linkedList.Append(10);
            linkedList.Append(20);
            linkedList.Append(30);
            Assert.AreEqual(1, linkedList.IndexOf(20), "Index of item 20 should be 1");
        }

        
        //[Test]
        //public void TestContains()
        //{
        //    linkedList.Append(10);
        //    linkedList.Append(20);
        //    linkedList.Append(30);
        //    Assert.IsTrue(linkedList.Contains(20), "List should contain item 20");
        //}

        //[Test]
        //public void TestClear()
        //{
        //    linkedList.Append(10);
        //    linkedList.Append(20);
        //    linkedList.Clear();
        //    Assert.AreEqual(0, linkedList.Count(), "Count should be 0 after clearing the list");
        //}
        
        //tests additional funcationaly of reverse
        [Test]
        public void TestReverse()
        {
            linkedList.Append(10);
            linkedList.Append(20);
            linkedList.Append(30);

            linkedList.Reverse();

            Assert.AreEqual(30, linkedList.GetAt(0), "First item should be 30 after reversing");
            Assert.AreEqual(20, linkedList.GetAt(1), "Second item should be 20 after reversing");
            Assert.AreEqual(10, linkedList.GetAt(2), "Third item should be 10 after reversing");
        }


    }
}
