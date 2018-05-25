using System;
using System.Collections.Generic;
using System.Text;

namespace StringMatching
{
    public class StraightInsertSort : SortStrategy
    {
        public override void Sort(List<Node> list)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            for (int i = 1; i < list.Count; i++)
            {
                int j = i - 1;
                Node current = list[i];

                while (j >= 0 && list[j].Count > current.Count)
                {
                    list[j + 1] = list[j];
                    j--;
                }
                list[j + 1] = current;
            }
        }
    }
}
