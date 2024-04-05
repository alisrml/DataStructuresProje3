using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProje3
{
    internal class MyHeap
    {
        private List<HEAPNODE> heapNodes;
        private int currentSize;

        public MyHeap()
        {
            this.currentSize = 0;
            heapNodes = new List<HEAPNODE>();

        }

        public Boolean isEmpty()
        {
            return heapNodes.Count == 0;
        }

        public void insert(UM_ALANI data)
        {
            HEAPNODE node = new HEAPNODE(data);
            heapNodes.Add(node);
            currentSize++;
            trickleUp(currentSize-1);
        }

        public void trickleUp(int index)
        {
            int parent = (index - 1) / 2;
            HEAPNODE bottom = heapNodes[index];

            while(index >0 && heapNodes[parent].getData().alanAdi.CompareTo(bottom.getData().alanAdi)>0) 
            {
                heapNodes[index] = heapNodes[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapNodes[index] = bottom;
        }

        public HEAPNODE remove()
        {
            HEAPNODE root = heapNodes[0];
            currentSize = heapNodes.Count;
            heapNodes[0] = heapNodes[currentSize-1];
            trickleDown(0);
            return root;
        }

        public void trickleDown(int index)
        {
            int smallerChild;
            HEAPNODE top = heapNodes[index];
            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;

                if(rightChild<currentSize && heapNodes[leftChild].getData().alanAdi.CompareTo(heapNodes[rightChild].getData().alanAdi) > 0)
                {
                    smallerChild = rightChild;
                }
                else
                {
                    smallerChild = leftChild;
                }
                if (top.getData().alanAdi.CompareTo(heapNodes[smallerChild].getData().alanAdi) <= 0)
                {
                    break;
                }

                heapNodes[index] = heapNodes[smallerChild];
                index = smallerChild;
            }
            heapNodes[index] = top;
        }

        public void change(int index,UM_ALANI newData)
        {
            UM_ALANI oldData = heapNodes[index].getData();
            heapNodes[index].setData(newData);

            if (oldData.alanAdi.CompareTo(newData.alanAdi) < 0)
            {
                trickleUp(index);
            }
            else
            {
                trickleDown(index);
            }
        }
    
        public void metot3c()
        {
            for (int i = 0; i < 3; i++)
            {
                UM_ALANI removedData = remove().getData();
                Console.WriteLine("Çıkarılan alan: " + removedData.ToString());
            }
        }
    }
}

