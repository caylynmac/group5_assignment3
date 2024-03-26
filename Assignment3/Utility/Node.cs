using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Utility
{
    public class Node
    {
        //can be primitive or object
        public User value;

        //pointer to my next node
        public Node next;

        public Node(User val)
        {
            value = val;
            next = null;
        }
    }
}
