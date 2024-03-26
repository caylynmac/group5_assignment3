using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Utility
{
    public class SLL : ILinkedListADT
    {
        public Node head;
        public SLL() { }    

        public bool IsEmpty()
        {
            return false;
        }

        public void Clear()
        {

        }

        public void AddLast(User value)
        {
            //look for node with null next

            //create new node
            Node newNode = new Node(value);
            newNode.next = null;
            //initialize temp 
            //temp is the node as the list is iterated
            //use to get/set the next of each node 
            Node temp = head;
           
            

            //need to check if list is empty first, so head can be properly assigned
            //if it is then use addfirst instead to just reassign head to new node
            if (head == null)
            {
                AddFirst(value);
                
            }

            if (head.next==null)
            {
                head.next = newNode;
                return;
            }
            

            //iterate through list 
            while (temp.next != null)
            {   //move to next node since we now know the previous is not null
                
                temp = temp.next;

                //if next is null, then re point to the new node
                //the next of newnode is null by default
                if (temp.next == null)
                {
                    
                    //point temp to newnode
                    temp.next = newNode;
                    return;
                    
                }
                //if not loop will repeat
            }
        }

        public void AddFirst(User value)
        {
            //create new node
            Node newNode = new Node(value);


            //point to old head
            newNode.next = head;

            //make head the new node
            head = newNode;
        }

        public void Add(User value, int index)
        {
            return;
        }

        public void Replace(User value, int index)
        {
            return;
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
            while (temp.next != null)
            {
                //increment count
                count++;
                
                //move to next node since we now know the previous is not null
                temp = temp.next;

                if (temp.next == null)
                {
                    return count;
                }
                
            }
            return count;
        }

        public void RemoveFirst()
        {
            //throw exception if list is empty
            if (head == null)
            {
                throw new System.ArgumentNullException("The List is empty");
            }

            //redefine second node (next item) as head
            //if the head is the only item, then the head will now point to null
            Node temp = head.next;
            head = temp;
        }


        public void RemoveLast()
        {
            //throw exception if list is empty
            if (head == null)
            {
                throw new System.ArgumentNullException("The List is empty");
            }
            //initialize temp 
            Node temp = head;
            Node prev = temp;

            //need to check if list is only one item first, so head can be properly reassigned
            //if it is then use removeFirst instead to just reassign head to null
            if (temp.next == null)
            {
                RemoveFirst();
            }
            //iterate through list 
            while (temp.next != null)
            {
                //move prev node
                prev = temp;

                //move to next node since we now know the previous is not null
                temp = temp.next;

                //if next is null (last node), then reset the node temp to null
                if (temp.next == null)
                {
                    Console.WriteLine(1);
                    //point previous node to null
                    prev.next = null;
                    return;
                }
            }
        }

        public void Remove(int index)
        {
            return;
        }

        public User GetValue(int index)
        {
            //throw exception if list is empty (count = 0)
            if (Count() == 0)
            {
                throw new ArgumentNullException("The list is empty");
            }
            //check if index is in range
            if (index > (Count() - 1) || index < 0)
            {
                throw new ArgumentOutOfRangeException("That index is Invalid");
            }

            //start at head
            Node temp = head;

            //empty user object to put match in
            User user = null;

            //this loop will iterate through numbers until the right index is reached
            //so that temp will be changed to the next corresponding node with each iteration
            for (int i = 0; i <= index; i++)
            {
                if (i == index)
                {
                    user = temp.value;
                }
                else
                {
                    //move to next node
                    temp = temp.next;
                }
            }
            return user;
        }
    

        public int IndexOf(User value)
        {
            return 0;
        }

        public bool Contains(User value)
        {
            return false;
        }

        //add another method from assignment list here
    }
}
