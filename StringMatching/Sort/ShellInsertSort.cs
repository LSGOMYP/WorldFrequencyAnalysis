using System;
using System.Collections.Generic;
using System.Text;

namespace StringMatching
{
    public class ShellInsertSort : SortStrategy
    {
        private void Shell(int delta, List<Node> list)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            //带增量的直接插入排序
            for (int i = delta; i < list.Count; i++)
            {
                int j = i - delta;
                Node current = list[i];

                while (j >= 0 && list[j].Count > current.Count)
                {
                    list[j + delta] = list[j];
                    j = j - delta;
                }
                list[j + delta] = current;
            }

        }

        public override void Sort(List<Node> list)
        {
            if (list == null)
                throw new ArgumentNullException("list");

            for (int delta = list.Count / 2; delta > 0; delta = delta / 2)
            {
                Shell(delta, list);
            }
        }
    }
}
