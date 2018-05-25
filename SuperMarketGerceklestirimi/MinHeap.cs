using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketGerceklestirimi
{
    public class MinHeap : AbstractHeap
    {
        public MinHeap(int capacity)
        {
        }


        internal override void heapifyDown()
        {
            int index = 0;
            while (hasLeftChild(index))
            {
                int smallerChildIndex = getLeftChildIndex(index);
                if (hasRightChild(index) && rightChild(index).Fiyat < leftChild(index).Fiyat)
                {
                    smallerChildIndex = getRightChildIndex(index);
                }

                if (Nodes[smallerChildIndex].Fiyat < Nodes[index].Fiyat)
                    swap(index, smallerChildIndex);
                else
                    break;
                index = smallerChildIndex;
            }
        }
        internal override void heapifyUp()
        {
            int index = Size - 1;

            while (hasParent(index) && parent(index).Fiyat > Nodes[index].Fiyat)
            {
                swap(index, getParentIndex(index));
                index = getParentIndex(index);
            }
        }

    }
}
