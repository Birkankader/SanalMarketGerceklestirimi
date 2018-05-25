using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketGerceklestirimi
{
    public class MaxHeap : AbstractHeap
    {

        public MaxHeap() : base()
        {
        }
  
        internal override void heapifyDown()
        {
            int index = 0;
            while (hasLeftChild(index))
            {
                int largerChildIndex = getLeftChildIndex(index);
                if (hasRightChild(index) && rightChild(index).Fiyat > leftChild(index).Fiyat)
                {
                    largerChildIndex = getRightChildIndex(index);
                }

                if (Nodes[largerChildIndex].Fiyat > Nodes[index].Fiyat)
                    swap(index, largerChildIndex);
                else
                    break;
                index = largerChildIndex;
            }
        }
        internal override void heapifyUp()
        {
            int index = Size - 1;

            while (hasParent(index) && parent(index).Fiyat < Nodes[index].Fiyat)
            {
                swap(index, getParentIndex(index));
                index = getParentIndex(index);
            }
        }
    
    }
}
