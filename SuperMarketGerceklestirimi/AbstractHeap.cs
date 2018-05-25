using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketGerceklestirimi
{
    public abstract class AbstractHeap
    {
        private int Capacity { get; set; }
        internal int Size { get; set; }
        internal Urun[] Nodes { get; set; }
     
        public AbstractHeap()
        {
            Capacity = 100;
            Size = 0;
            Nodes = new Urun[Capacity];
        }

        #region helperMethods
        public void EnlargeIfNeeded()
        {
            if (Size == Capacity)
            {
                Capacity = 2 * Capacity;
                Array.Copy(Nodes, Nodes, Capacity);
            }
        }

        public int getLeftChildIndex(int parentIndex)
        {
            return 2 * parentIndex + 1;
        }

        public bool hasLeftChild(int parentIndex)
        {
            return getLeftChildIndex(parentIndex) < Size;
        }

        public Urun leftChild(int index)
        {
            return Nodes[getLeftChildIndex(index)];
        }

        public int getRightChildIndex(int parentIndex)
        {
            return 2 * parentIndex + 2;
        }

        public bool hasRightChild(int parentIndex)
        {
            return getRightChildIndex(parentIndex) < Size;
        }

        public Urun rightChild(int index)
        {
            return Nodes[getRightChildIndex(index)];
        }

        public int getParentIndex(int childIndex)
        {
            return (childIndex - 1) / 2;
        }

        public bool hasParent(int childIndex)
        {
            return getParentIndex(childIndex) >= 0;
        }

        public Urun parent(int index)
        {
            return Nodes[getParentIndex(index)];
        }

        public void swap(int index1, int index2)
        {
            Urun temp = Nodes[index1];
            Nodes[index1] = Nodes[index2];
            Nodes[index2] = temp;
        }

        #endregion


        public Urun peek()
        {
            if (Size == 0)
                throw new InvalidOperationException("Heap is empty");

            return Nodes[0];
        }

        public Urun pop()
        {
            if (Size == 0)
                throw new InvalidOperationException("Heap is empty");

            Urun item = Nodes[0];
            Nodes[0] = Nodes[Size - 1];
            Size--;
            heapifyDown();
            return item;
        }

       
        public void add(Urun item)
        {
            EnlargeIfNeeded();
            Nodes[Size] = item;
            Size++;
            heapifyUp();
        }

        internal abstract void heapifyUp();
        internal abstract void heapifyDown();
    }
}
