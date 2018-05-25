using System;
using System.Collections.Generic;
using System.Text;

namespace StringMatching
{
    public class StraightSelectSort : SortStrategy
    {
        public override void Sort(List<Node> list)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            for (int i = 0; i < list.Count - 1; i++)
            {
                int k = i;
                Node current = list[i];

                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j].Count < current.Count)
                    {
                        current = list[j];
                        k = j;
                    }
                }
                if (k != i)
                {
                    list[k] = list[i];
                    list[i] = current;
                }
            }
        }
    }
}
