using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringMatching
{
    public class LambdaSort:SortStrategy
    {
        public override void Sort(List<Node> list)
        {
            list.Sort((node1, node2)
                      => node1.Count.CompareTo(node2.Count));
        }
    }
}
