using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GA_LinearSearch
{
    public class CustomList<T>
    {
        T[] internalArray;
        int count;

        //Constractor

        public CustomList() : this(15) { }

        public CustomList(int index)
        {
            internalArray = new T[index];
            count = 0;
        }
        public void Add(T item)
        {
            //Pre and Post increment
            //count++
            CheckCapacity();
            internalArray[count++] = item;
        }
        
        private void CheckCapacity()
        {
            //If over 80% of our array is used, run this code
            if (count / (double)internalArray.Length > .8)
            {
                //Doubling the size of capacity(Array)
                T[] tempArray = new T[internalArray.Length *2];
                for (int i = 0; i < internalArray.Length; i++)
                {
                    tempArray[i] = internalArray[i];
                }

                internalArray = tempArray;
            }

        }
        public T GetAtIndex(int index)
        {
            if(index < 0 || index > count)  return default(T);

            return internalArray[index];
        }
        //to show overide index in C#
        public T this[int index]
        {
            get => internalArray[index];
        }

        public void RemoveAt(int index)
        {
            int current = index;
            while (current < count)
            {
                internalArray[current] = internalArray[current + 1];
                current++;
            }
             
            count--;
        }
        public void Displayinformatio()
        {
           /* foreach (T item in internalArray)
            {
                Console.WriteLine( item);
            }*/
           for (int i = 0; i < internalArray.Length; i++)
            {
                Console.WriteLine($"{i}: {internalArray[i]}");
            }
        }
        public int Capacity
        {
            get => internalArray.Length;    
        }

        //Array
        //Pros
        //Fast
        //efficient
        //Cons
        
    }
}
