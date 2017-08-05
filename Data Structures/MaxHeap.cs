using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    public class MaxHeap<T> where T : IComparable
    {
        public List<T> items = new List<T>();

        public void Insert(T o)
        {
            items.Add(o);

            int elemIndex = items.Count - 1;
            int parentIndex = (elemIndex + 1) / 2 - 1;

            while(elemIndex > 0)
            {
                T parentElem = items[parentIndex];
                if (parentElem.CompareTo(o) >= 0)
                    break;

                T tmp = items[parentIndex];
                items[parentIndex] = items[elemIndex];
                items[elemIndex] = tmp;

                elemIndex = parentIndex;
            }
        }

        public T MaxElement()
        {
            T max = items[0];
            items[0] = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            MaxHeapify(0);
            return max;
        }

        public void MaxHeapify(int i)
        {
            int leftIndex = 2 * (i + 1) - 1, rightIndex = 2 * (i + 1), largest;

            if (leftIndex <= items.Count - 1 && items[leftIndex].CompareTo(items[i]) > 0)
                largest = leftIndex;
            else
                largest = i;

            if (rightIndex <= items.Count - 1 && items[rightIndex].CompareTo(items[largest]) > 0)
                largest = rightIndex;

            if(largest != i)
            {
                T tmp = items[i];
                items[i] = items[largest];
                items[largest] = tmp;
                MaxHeapify(largest);
            }
        }

        public int Count
        {
            get { return items.Count; }
        }

        public T Peek()
        {
            return items.First();
        }
    }
}
