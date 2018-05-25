using System;
using System.Collections.Generic;
using System.Text;

namespace StringMatching
{
    public class Node
    {
        public int Count { get; set; }
        public string SubString { get; set; }

        public Node(string substr)
        {
            Count = 0;
            SubString = substr;
        }
    }
}
