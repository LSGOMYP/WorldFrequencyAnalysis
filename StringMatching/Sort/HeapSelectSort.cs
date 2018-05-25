using System;
using System.Collections.Generic;
using System.Text;

namespace StringMatching
{
    public class HeapSelectSort : SortStrategy
    {
        private static void Restore(Node[] key, int j, int vCount)
        {
            //构建以结点j为根,一共有vCount个结点的大根堆
            while (j <= vCount/2)
            {
                int m = (2*j + 1 <= vCount && key[2*j + 1].Count > key[2*j].Count) ? 2*j + 1 : 2*j;
                if (key[m].Count > key[j].Count)
                {
                    Node temp = key[m];
                    key[m] = key[j];
                    key[j] = temp;
                    j = m;
                }
                else
                {
                    break;
                }
            }
        }

        public override void Sort(List<Node> list)
        {
            int vCount = list.Count;
            Node[] tempKey = new Node[vCount + 1];

            for (int i = 0; i < vCount; i++)
                tempKey[i + 1] = list[i];

            for (int i = vCount/2; i >= 1; i--)
                Restore(tempKey, i, vCount);

            for (int i = vCount; i > 1; i--)
            {
                Node temp = tempKey[i];
                tempKey[i] = tempKey[1];
                tempKey[1] = temp;
                Restore(tempKey, 1, i - 1);
            }

            for (int i = 0; i < vCount; i++)
                list[i] = tempKey[i + 1];
        }
    }
}
