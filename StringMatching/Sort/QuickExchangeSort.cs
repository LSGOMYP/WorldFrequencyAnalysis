using System;
using System.Collections.Generic;
using System.Text;

namespace StringMatching
{
    public class QuickExchangeSort: SortStrategy
    {
        private void QuickSort(List<Node> list, int left, int right)
        {
            //快速排序递归函数
            if (left < right)
            {
                Node current = list[left];
                int i = left;
                int j = right;
                while (i < j)
                {
                    while (list[j].Count > current.Count && i < j)
                        j--;
                    while (list[i].Count <= current.Count && i < j)
                        i++;
                    if (i < j)
                    {
                        Node temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
                list[left] = list[j];
                list[j] = current;
                if (left < j - 1) QuickSort(list, left, j - 1);
                if (right > j + 1) QuickSort(list, j + 1, right);
            }
        }
        public override void Sort(List<Node> list)
        {
            QuickSort(list, 0, list.Count - 1);
        }
    }
}
