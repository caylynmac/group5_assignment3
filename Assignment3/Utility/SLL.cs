using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Assignment3.ProblemDomain;
using Assignment3;

namespace Assignment3.Utility
{
    [Serializable]
    public class SLL : ILinkedListADT
    {
        private Node head;

        public bool IsEmpty()
        {
            return head == null;
        }

        public void Clear()
        {
            head = null;
        }

        public void AddLast(User value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void AddFirst(User value)
        {
            //create new node
            Node newNode = new Node(value);


            //point to old head
            newNode.Next = head;

            //make head the new node
            head = newNode;
        }

        public void Add(User value, int index)
        {
            if (index < 0 || index > Count())
            {
                throw new IndexOutOfRangeException("Invalid index");
            }

            if (index == 0)
            {
                AddFirst(value);
            }
            else if (index == Count())
            {
                AddLast(value);
            }
            else
            {
                Node newNode = new Node(value);
                Node temp = head;
                for (int i = 0; i < index - 1; i++)
                {
                    temp = temp.Next;
                }
                newNode.Next = temp.Next;
                temp.Next = newNode;
            }
        }

        public void Replace(User value, int index)
        {
            if (index < 0 || index >= Count())
            {
                throw new IndexOutOfRangeException("Invalid index");
            }

            Node temp = head;
            for (int i = 0; i < index; i++)
            {
                temp = temp.Next;
            }
            temp.Value = value;
        }

        public int Count()
        {
            //throw exception if list is empty
            if (head == null)
            {
                return 0;
            }
            //initialize temp 
            Node temp = head;

            //initialize count
            int count = 1;

            //iterate through list, count nodes
            while (temp.Next != null)
            {
                //increment count
                count++;

                //move to next node since we now know the previous is not null
                temp = temp.Next;

                if (temp.Next == null)
                {
                    return count;
                }

            }
            return count;
            //int count = 0;
            //Node current = head;
            //while (current != null)
            //{
            //    count++;
            //    current = current.Next;
            //}
            //return count;
        }

        public void RemoveFirst()
        {
            if (head != null)
            {
                head = head.Next;
            }
        }

        public void RemoveLast()
        {
            if (head == null)
            {
                return;
            }

            if (head.Next == null)
            {
                head = null;
                return;
            }

            Node temp = head;
            while (temp.Next.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = null;
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= Count())
            {
                throw new IndexOutOfRangeException("Invalid index");
            }

            if (index == 0)
            {
                RemoveFirst();
            }
            else if (index == Count() - 1)
            {
                RemoveLast();
            }
            else
            {
                Node temp = head;
                for (int i = 0; i < index - 1; i++)
                {
                    temp = temp.Next;
                }
                temp.Next = temp.Next.Next;
            }
        }

        public User GetValue(int index)
        {
            if (index < 0 || index >= Count())
            {
                throw new IndexOutOfRangeException("Invalid index");
            }

            Node temp = head;
            for (int i = 0; i < index; i++)
            {
                temp = temp.Next;
            }
            return temp.Value;
        }

        public int IndexOf(User value)
        {
            Node temp = head;
            int index = 0;
            while (temp != null)
            {
                if (temp.Value.Equals(value))
                {
                    return index;
                }
                temp = temp.Next;
                index++;
            }
            return -1;
        }

        public bool Contains(User value)
        {
            return IndexOf(value) != -1;
        }

        public void Reverse()
        {
            Node prev = null;
            Node current = head;
            Node next = null;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }

        public void Sort()
        {
            // Placeholder for sorting logic
        }

        public User[] CopyToArray()
        {
            // Placeholder for copying logic
            return null;
        }

        public void Join(ILinkedListADT otherList)
        {
            // Placeholder for joining logic
        }

        public (ILinkedListADT, ILinkedListADT) Divide(int index)
        {
            // Placeholder for division logic
            return (null, null);
        }
    }
}
