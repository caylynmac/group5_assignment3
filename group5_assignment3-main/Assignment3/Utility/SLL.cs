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
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
            }
        }

        public void AddFirst(User value)
        {
            Node newNode = new Node(value);
            newNode.next = head;
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
                    temp = temp.next;
                }
                newNode.next = temp.next;
                temp.next = newNode;
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
                temp = temp.next;
            }
            temp.value = value;
        }

        public int Count()
        {
            int count = 0;
            Node current = head;
            while (current != null)
            {
                count++;
                current = current.next;
            }
            return count;
        }

        public void RemoveFirst()
        {
            if (head != null)
            {
                head = head.next;
            }
        }

        public void RemoveLast()
        {
            if (head == null)
            {
                return;
            }

            if (head.next == null)
            {
                head = null;
                return;
            }

            Node temp = head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next = null;
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
                    temp = temp.next;
                }
                temp.next = temp.next.next;
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
                temp = temp.next;
            }
            return temp.value;
        }

        public int IndexOf(User value)
        {
            Node temp = head;
            int index = 0;
            while (temp != null)
            {
                if (temp.value.Equals(value))
                {
                    return index;
                }
                temp = temp.next;
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
                next = current.next;
                current.next = prev;
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
