using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3.Utility;
using Assignment3.ProblemDomain;
using Assignment3;
namespace Assignment3.Utility
{
    [Serializable]
    public class Node
    {
        public User Value { get; set; }

        public Node Next { get; set; }

        public Node(User val)
        {
            Value = val;
            Next = null;
        }
    }
}
