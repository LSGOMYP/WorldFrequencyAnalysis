﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StringMatching
{
    public class BubbleExchangeSort : SortStrategy
    {
        public override void Sort(List<Node> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = list.Count - 1; j > i; j--)
                {
                    if (list[j].Count < list[j - 1].Count)
                    {
                        Node temp = list[j - 1];
                        list[j - 1] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }
    }
}
